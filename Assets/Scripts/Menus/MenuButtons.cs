using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject[] loadSlots;
    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
    public void Slot(int slotNum)
    {
        PlayerData.saveSlot = slotNum;
    }
    public void LoadSlots()
    {
        StartCoroutine(PlayerStats(SlotsLoaded));
    }
    IEnumerator PlayerStats(Action<string> doneFunction)
    {

        string databaseURL = "http://localhost/nsirpg/selectcharacter.php";
        WWWForm form = new WWWForm();

        UnityWebRequest webRequest = UnityWebRequest.Post(databaseURL, form);
        yield return webRequest.SendWebRequest();
        doneFunction(webRequest.downloadHandler.text);

    }
    public void SlotsLoaded(string result)
    {
        bool[] charsAvailable = new bool[3];

        for(int i = 0; i < 3; ++i)
        {
            charsAvailable[i] = false;
        }

        Debug.Log(result);
        if (result.Contains("|") || (result.Equals("")))
        {
            foreach (var data in result.Split('|'))
            {
                if(!data.Equals(""))
                {
                    charsAvailable[System.Int32.Parse(data)] = true;
                }
            }
            
        }

        for (int i = 0; i < 3; ++i)
        {
            loadSlots[i].SetActive(charsAvailable[i]);
                
        }

    }
    public void LoadCharacterSlot(int slotIndex)
    {
        StartCoroutine(LoadCharacterSlotSQLCommand(ProcessCharacterInfo, slotIndex));
    }

    IEnumerator LoadCharacterSlotSQLCommand(Action<string> doneFunction, int slotIdx)
    {

        string databaseURL = "http://localhost/nsirpg/loadcustomisation.php";
        WWWForm form = new WWWForm();
        form.AddField("slotIndex", slotIdx);

        UnityWebRequest webRequest = UnityWebRequest.Post(databaseURL, form);
        yield return webRequest.SendWebRequest();
        doneFunction(webRequest.downloadHandler.text);

    }
    public void ProcessCharacterInfo(string result)
    {
        Debug.Log(result);
        if (result.Contains("|") || (result.Equals("")))
        {
            string[] results = result.Split('|');
            PlayerDatabaseData database = new PlayerDatabaseData();
            database.charName = (results[0]);
            database.classEnumIndex = System.Int32.Parse(results[1]);
            database.skinIndex = System.Int32.Parse(results[2]);
            database.eyesIndex = System.Int32.Parse(results[3]);
            database.mouthIndex = System.Int32.Parse(results[4]);
            database.hairIndex = System.Int32.Parse(results[5]);
            database.clothesIndex = System.Int32.Parse(results[6]);
            database.armourIndex = System.Int32.Parse(results[7]);
            database.strengthIndex = System.Int32.Parse(results[8]);
            database.constitutionIndex = System.Int32.Parse(results[9]);
            database.dexterityIndex = System.Int32.Parse(results[10]);
            database.intelligenceIndex = System.Int32.Parse(results[11]);
            database.wisdomIndex = System.Int32.Parse(results[12]);
            database.charismaIndex = System.Int32.Parse(results[13]);

            PlayerSaveAndLoad.database = database;

            SceneManager.LoadScene(2);
        }
    }
}
