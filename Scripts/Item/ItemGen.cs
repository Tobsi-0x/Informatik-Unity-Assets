using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGen : MonoBehaviour
{

    ItemBase baseStats;

    /*public class ItemBase 
    {
        enum rarity
        {
            COMMON,     // hex: #ffffff
            UNCOMMON,   // hex: #1eff00
            RARE,       // hex: #0070dd
            EPIC,       // hex: #a335ee
            LEGENDARY,  // hex: #ff8000
            DEV_ITEM    // hex: #ff0033
        }

        public string item_name;
        public string item_desc;
        public string item_type;
        public string item_price_buy;
        public string item_price_sell;
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

    }*/

    /*class GenWeapon : ItemBase
    {

    }*/

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    
    public void MakeLvLOneWeapon()
    {
        Debug.Log("MakeLvLOneWeapon CALLED");
    }
}
