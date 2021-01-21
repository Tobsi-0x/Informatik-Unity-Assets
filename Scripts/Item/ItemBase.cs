using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    //public static readonly string SAVE_FOLDER = Application.dataPath + "/ItemSave/";
    public int saveNumb = 1;

    public enum GeneratorType
    {
        WEAPON,
        CONSUMABLE,
        ARMOR
    }

    public GeneratorType genType = GeneratorType.WEAPON;

    public enum RarityType
    {
        COMMON,     // hex: #ffffff
        UNCOMMON,   // hex: #1eff00
        RARE,       // hex: #0070dd
        EPIC,       // hex: #a335ee
        LEGENDARY,  // hex: #ff8000
        DEV_ITEM    // hex: #ff0033
    }

    public RarityType rarity = RarityType.COMMON;

    public int item_ID;
    public string item_name;
    public string item_desc;
    public string item_type;
    public int item_price_buy;
    public int item_price_sell;
    public int lvl; // level requirement

    public bool canEquip;
    public bool canConsume;
    public bool canSell;

    //Att points // https://tvtropes.org/pmwiki/pmwiki.php/Main/TheSixStats 
    public double Str; // attack power
    public double Dex; // dodge chance
    public double Con; // armor
    public double Int; // XP rate (higher int, more XP pr. kill)
    // public double Wis; // 
    public double Luc; // increse the drop chance // Charisma
    public double speed; // ved ikke om dette vil være sjovt. modstanders Dodge chance stiger.

    /*  // Random Number Stuff //   */
    public double minStr;
    public double maxStr;

    public double minDex;
    public double maxDex;

    public double minCon;
    public double maxCon;

    public double minInt;
    public double maxInt;

    public double minLuc;
    public double maxLuc;

    public double minspeed;
    public double maxspeed;


    public void MakeLvLOneWeapon()
    {
        Debug.Log("MakeLvLOneWeapon CALLED");

        // TODO: Make something to generate item, save them and access them.

    }

    public int GetLatestItemInCatagory()
    {
        //int id = 0;

        // BRUG genType FRA FØR.

        // Scan file.

        item_ID = 0; // TEMP, USE THE ONE UNDER WHEN DONE

        //item_ID = id;
        return 0;

    }

    public void ItemTestSave()
    {

    }


    public void ManualItemOverwrite()
    {
        Save();
        Debug.Log("===============");
        Load();
    }

    private class ItemDataSave
    {
        public int item_IDS;

        public ItemBase.GeneratorType genTypeS;

        public ItemBase.RarityType rarityS;

        public string item_nameS;
        public string item_descS;
        public string item_typeS;
        public int item_price_buyS;
        public int item_price_sellS;
        public int lvlS; 

        public bool canEquipS;
        public bool canConsumeS;
        public bool canSellS;

        //Att points
        public double StrS; 
        public double DexS; 
        public double ConS; 
        public double IntS; 
                           
        public double LucS; 
        public double speedS;

        /*  // Random Number Stuff //   */
        public double minStrS;
        public double maxStrS;

        public double minDexS;
        public double maxDexS;

        public double minConS;
        public double maxConS;

        public double minIntS;
        public double maxIntS;

        public double minLucS;
        public double maxLucS;

        public double minspeedS;
        public double maxspeedS;
    }

    public void Save()
    {
        if(!Directory.Exists(Application.dataPath + "/ItemSave/"))
        {
            Directory.CreateDirectory(Application.dataPath + "/ItemSave/");
        }

        if(!Directory.Exists(Application.dataPath + "/ItemSave/" + genType.ToString() + "/"))
        {
            Directory.CreateDirectory(Application.dataPath + "/ItemSave/" + genType.ToString() + "/");
        }

        
        while(File.Exists(Application.dataPath + "/ItemSave/" + genType.ToString() + "/" + genType.ToString() + "_item_" + saveNumb + ".txt")) // senere lav det til item navn.
        {
            saveNumb++;
        }

        ItemDataSave saveObj = new ItemDataSave
        {
            item_IDS = item_ID,
            genTypeS = genType,
            rarityS = rarity,
            item_nameS = item_name,
            item_descS = item_desc,
            item_typeS = item_type,
            item_price_buyS = item_price_buy,
            item_price_sellS = item_price_sell,
            lvlS = lvl,
            canEquipS = canEquip,
            canConsumeS = canConsume,
            canSellS = canSell,
            //Att points
            StrS = Str,
            DexS = Dex,
            ConS = Con,
            IntS = Int,
            LucS = Luc,
            speedS = speed,

            /*  // Random Number Stuff //   */
            minStrS = minStr,
            maxStrS = maxStr,

            minDexS = minDex,
            maxDexS = maxDex,

            minConS = minCon,
            maxConS = maxCon,

            minIntS = minInt,
            maxIntS = maxInt,

            minLucS = minLuc,
            maxLucS = maxLuc,

            minspeedS = minspeed,
            maxspeedS = maxspeed
        };

        // Save
        string json = JsonUtility.ToJson(saveObj);
        Debug.Log(json);

        File.WriteAllText(Application.dataPath + "/ItemSave/" + genType.ToString() + "/" + genType.ToString() + "_item_" + saveNumb + ".txt", json); // senere lav det til item navn.
    }

    public void Load()
    {

        if(File.Exists(Application.dataPath + "/ItemSave/" + genType.ToString() + "/" + genType.ToString() + "_item_" + saveNumb + ".txt"))
        {
            // Load
            string loadedJson = File.ReadAllText(Application.dataPath + "/ItemSave/" + "/" + genType.ToString() + "/" + genType.ToString() + "_item_" + saveNumb + ".txt");

            ItemDataSave loadedSave = JsonUtility.FromJson<ItemDataSave>(loadedJson);
            Debug.Log(loadedJson);

            //Set TODO: Set all the loaded stuff in here
            Str = loadedSave.StrS + 1;
        }
        else { Debug.LogError(Application.dataPath + "/ItemSave/" + genType.ToString() + "/" + genType.ToString() + "_item_" + saveNumb + ".txt" + " File does not exist."); }

    }
}
