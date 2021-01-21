using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
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

}
