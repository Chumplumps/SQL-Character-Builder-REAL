using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerDatabase : MonoBehaviour
{
    public int skinIndex, hairIndex, mouthIndex, eyesIndex, clothesIndex, armourIndex,classEnumIndex, strengthIndex, constitutionIndex, dexterityIndex, intelligenceIndex, wisdomIndex, charismaIndex, slotIndex;
    public string charName;

    IEnumerator PlayerStats(Action<string> doneFunction, string playerName, int skin, int hair, int mouth, int eyes, int clothes, int armour,int classIndex, int strength, int constitution, int dexterity, int intelligence, int wisdom, int charisma, int slot)
    {
        
        string databaseURL = "http://localhost/nsirpg/customisation.php";
        WWWForm form = new WWWForm();
        form.AddField("charName", playerName);
        form.AddField("skinIndex", skin);
        form.AddField("hairIndex", hair);
        form.AddField("mouthIndex", mouth);
        form.AddField("eyesIndex", eyes);
        form.AddField("clothesIndex", clothes);
        form.AddField("armourIndex", armour);
        form.AddField("classEnumIndex", classIndex);
        form.AddField("strengthIndex", strength);
        form.AddField("constitutionIndex", constitution);
        form.AddField("dexterityIndex", dexterity);
        form.AddField("intelligenceIndex", intelligence);
        form.AddField("wisdomIndex", wisdom);
        form.AddField("charismaIndex", charisma);
        form.AddField("slotIndex", slot);
        UnityWebRequest webRequest = UnityWebRequest.Post(databaseURL, form);
        yield return webRequest.SendWebRequest();
        doneFunction(webRequest.downloadHandler.text);
      
    }
    public void SavingToDataBase(Action<string> doneFunction)
    {
        StartCoroutine(PlayerStats(doneFunction, charName, skinIndex, hairIndex, mouthIndex, eyesIndex, clothesIndex, armourIndex, classEnumIndex, strengthIndex, constitutionIndex, dexterityIndex, intelligenceIndex, wisdomIndex, charismaIndex, slotIndex));
    }
}

public class PlayerDatabaseData
{
    public int skinIndex, hairIndex, mouthIndex, eyesIndex, clothesIndex, armourIndex, classEnumIndex, strengthIndex, constitutionIndex, dexterityIndex, intelligenceIndex, wisdomIndex, charismaIndex, slotIndex;
    public string charName;
};