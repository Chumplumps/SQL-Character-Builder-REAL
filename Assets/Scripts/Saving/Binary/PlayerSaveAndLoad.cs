using UnityEngine;
public class PlayerSaveAndLoad : MonoBehaviour
{
    public PlayerHandler player;
    public bool custom;
    public static PlayerDatabaseData database;
    private void Start()
    {
      if(!custom)
        {
            Load();
        }
    }    
    public void Save()
    {
        PlayerBinary.SavePlayerData(player);
    }
    public void Load()
    {        PlayerData data = PlayerBinary.LoadData(player);
        player.name = database.charName;
        player.skinIndex = database.skinIndex;
        player.hairIndex = database.hairIndex;
        player.mouthIndex = database.mouthIndex;
        player.eyesIndex = database.eyesIndex;
        player.clothesIndex = database.clothesIndex;
        player.armourIndex = database.armourIndex;

        player.characterClass = (CharacterClass)database.classEnumIndex;
        player.characterName = database.charName;


        player.stats[0].value = database.strengthIndex;
        player.stats[1].value = database.dexterityIndex;
        player.stats[2].value = database.constitutionIndex;
        player.stats[3].value = database.wisdomIndex;
        player.stats[4].value = database.intelligenceIndex;
        player.stats[5].value = database.charismaIndex;
        Debug.Log("Loading stuffs");
        LoadCustomisation.SetTexture("Skin", database.skinIndex);
        LoadCustomisation.SetTexture("Hair", database.hairIndex);
        LoadCustomisation.SetTexture("Mouth", database.mouthIndex);
        LoadCustomisation.SetTexture("Eyes", database.eyesIndex);
        LoadCustomisation.SetTexture("Clothes", database.clothesIndex);
        LoadCustomisation.SetTexture("Armour", database.armourIndex);
    }
}
