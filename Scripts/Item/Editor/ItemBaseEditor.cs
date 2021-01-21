using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ItemBase), true)]
public class ItemBaseEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI(); // Everything (public variables)

        ItemBase itemB = (ItemBase)target;


        if (GUILayout.Button("Get Latest Item In Category"))
        {
            itemB.GetLatestItemInCatagory();
        }

        itemB.genType = (ItemBase.GeneratorType)EditorGUILayout.EnumPopup("Generate: ", itemB.genType);

        if (itemB.genType == ItemBase.GeneratorType.WEAPON)
        {
            GUILayout.Label("Weapon");

            // Weapon Stats
            GUILayout.Label("WEAPON STATS===================");

            itemB.item_ID = EditorGUILayout.IntField("Weapon ID: ", itemB.item_ID);

            itemB.rarity = (ItemBase.RarityType)EditorGUILayout.EnumPopup("Rarity: ", itemB.rarity);

            itemB.item_name = EditorGUILayout.TextField("Item Name: ", itemB.item_name);
            itemB.item_desc = EditorGUILayout.TextField("Item Description: ", itemB.item_desc);
            itemB.item_type = EditorGUILayout.TextField("Item Type: ", itemB.item_type);

            itemB.item_price_buy = EditorGUILayout.IntField("Item Buy Price: ", itemB.item_price_buy);
            itemB.item_price_sell = EditorGUILayout.IntField("Item Sell Price: ", itemB.item_price_sell);

            itemB.lvl = EditorGUILayout.IntField("Item lvl: ", itemB.lvl); // level requirement

            itemB.canEquip = EditorGUILayout.Toggle("canEquip: ", itemB.canEquip);
            itemB.canConsume = EditorGUILayout.Toggle("canConsume: ", itemB.canConsume);
            itemB.canSell = EditorGUILayout.Toggle("canSell: ", itemB.canSell);

            itemB.Str = EditorGUILayout.DoubleField("Str: ", itemB.Str);
            itemB.Dex = EditorGUILayout.DoubleField("Dex: ", itemB.Dex);
            itemB.Con = EditorGUILayout.DoubleField("Con: ", itemB.Con);
            itemB.Int = EditorGUILayout.DoubleField("Int: ", itemB.Int);
            itemB.Luc = EditorGUILayout.DoubleField("Luc: ", itemB.Luc);
            itemB.speed = EditorGUILayout.DoubleField("speed: ", itemB.speed);

            GUILayout.Label("===============================");

            // Random Var
            GUILayout.Label("RANDOM-VARIABLES ===============");

            itemB.maxStr = EditorGUILayout.DoubleField("Max Str: ", itemB.maxStr);
            itemB.minStr = EditorGUILayout.DoubleField("Min Str: ", itemB.minStr);

            itemB.maxDex = EditorGUILayout.DoubleField("Max Dex: ", itemB.maxDex);
            itemB.minDex = EditorGUILayout.DoubleField("Min Dex: ", itemB.minDex);

            itemB.maxCon = EditorGUILayout.DoubleField("Max Con: ", itemB.maxCon);
            itemB.minCon = EditorGUILayout.DoubleField("Min Con: ", itemB.minCon);

            itemB.maxInt = EditorGUILayout.DoubleField("Max Int: ", itemB.maxInt);
            itemB.minInt = EditorGUILayout.DoubleField("Min Int: ", itemB.minInt);

            itemB.maxLuc = EditorGUILayout.DoubleField("Max Luc: ", itemB.maxLuc);
            itemB.minLuc = EditorGUILayout.DoubleField("Min Luc: ", itemB.minLuc);

            itemB.maxspeed = EditorGUILayout.DoubleField("Max speed: ", itemB.maxspeed);
            itemB.minspeed = EditorGUILayout.DoubleField("Min speed: ", itemB.minspeed);

            GUILayout.Label("===============================");

        }
        if (itemB.genType == ItemBase.GeneratorType.ARMOR)
        {
            GUILayout.Label("Armor");

            GUILayout.Label("ARMOR STATS====================");

            itemB.item_ID = EditorGUILayout.IntField("Armor ID: ", itemB.item_ID);

            itemB.rarity = (ItemBase.RarityType)EditorGUILayout.EnumPopup("Rarity: ", itemB.rarity);

            itemB.item_name = EditorGUILayout.TextField("Item Name: ", itemB.item_name);
            itemB.item_desc = EditorGUILayout.TextField("Item Description: ", itemB.item_desc);
            itemB.item_type = EditorGUILayout.TextField("Item Type: ", itemB.item_type);

            itemB.item_price_buy = EditorGUILayout.IntField("Item Buy Price: ", itemB.item_price_buy);
            itemB.item_price_sell = EditorGUILayout.IntField("Item Sell Price: ", itemB.item_price_sell);

            itemB.lvl = EditorGUILayout.IntField("Item lvl: ", itemB.lvl); // level requirement

            itemB.canEquip = EditorGUILayout.Toggle("canEquip: ", itemB.canEquip);
            itemB.canConsume = EditorGUILayout.Toggle("canConsume: ", itemB.canConsume);
            itemB.canSell = EditorGUILayout.Toggle("canSell: ", itemB.canSell);

            itemB.Str = EditorGUILayout.DoubleField("Str: ", itemB.Str);
            itemB.Dex = EditorGUILayout.DoubleField("Dex: ", itemB.Dex);
            itemB.Con = EditorGUILayout.DoubleField("Con: ", itemB.Con);
            itemB.Int = EditorGUILayout.DoubleField("Int: ", itemB.Int);
            itemB.Luc = EditorGUILayout.DoubleField("Luc: ", itemB.Luc);
            itemB.speed = EditorGUILayout.DoubleField("speed: ", itemB.speed);

            GUILayout.Label("===============================");

            // Random Var
            GUILayout.Label("RANDOM-VARIABLES ===============");

            itemB.maxStr = EditorGUILayout.DoubleField("Max Str: ", itemB.maxStr);
            itemB.minStr = EditorGUILayout.DoubleField("Min Str: ", itemB.minStr);

            itemB.maxDex = EditorGUILayout.DoubleField("Max Dex: ", itemB.maxDex);
            itemB.minDex = EditorGUILayout.DoubleField("Min Dex: ", itemB.minDex);

            itemB.maxCon = EditorGUILayout.DoubleField("Max Con: ", itemB.maxCon);
            itemB.minCon = EditorGUILayout.DoubleField("Min Con: ", itemB.minCon);

            itemB.maxInt = EditorGUILayout.DoubleField("Max Int: ", itemB.maxInt);
            itemB.minInt = EditorGUILayout.DoubleField("Min Int: ", itemB.minInt);

            itemB.maxLuc = EditorGUILayout.DoubleField("Max Luc: ", itemB.maxLuc);
            itemB.minLuc = EditorGUILayout.DoubleField("Min Luc: ", itemB.minLuc);

            itemB.maxspeed = EditorGUILayout.DoubleField("Max speed: ", itemB.maxspeed);
            itemB.minspeed = EditorGUILayout.DoubleField("Min speed: ", itemB.minspeed);

            GUILayout.Label("===============================");
        }
        if(itemB.genType == ItemBase.GeneratorType.CONSUMABLE)
        {
            
            GUILayout.Label("Consumable");

            GUILayout.Label("CONSUMABLE STATS===============");

            itemB.item_ID = EditorGUILayout.IntField("Consumable ID: ", itemB.item_ID);

            itemB.rarity = (ItemBase.RarityType)EditorGUILayout.EnumPopup("Rarity: ", itemB.rarity);

            itemB.item_name = EditorGUILayout.TextField("Item Name: ", itemB.item_name);
            itemB.item_desc = EditorGUILayout.TextField("Item Description: ", itemB.item_desc);
            itemB.item_type = EditorGUILayout.TextField("Item Type: ", itemB.item_type);

            itemB.item_price_buy = EditorGUILayout.IntField("Item Buy Price: ", itemB.item_price_buy);
            itemB.item_price_sell = EditorGUILayout.IntField("Item Sell Price: ", itemB.item_price_sell);

            itemB.lvl = EditorGUILayout.IntField("Item lvl: ", itemB.lvl); // level requirement

            itemB.canEquip = EditorGUILayout.Toggle("canEquip: ", itemB.canEquip);
            itemB.canConsume = EditorGUILayout.Toggle("canConsume: ", itemB.canConsume);
            itemB.canSell = EditorGUILayout.Toggle("canSell: ", itemB.canSell);

            itemB.Str = EditorGUILayout.DoubleField("Str: ", itemB.Str);
            itemB.Dex = EditorGUILayout.DoubleField("Dex: ", itemB.Dex);
            itemB.Con = EditorGUILayout.DoubleField("Con: ", itemB.Con);
            itemB.Int = EditorGUILayout.DoubleField("Int: ", itemB.Int);
            itemB.Luc = EditorGUILayout.DoubleField("Luc: ", itemB.Luc);
            itemB.speed = EditorGUILayout.DoubleField("speed: ", itemB.speed);

            GUILayout.Label("===============================");

            // Random Var
            GUILayout.Label("RANDOM-VARIABLES ===============");

            itemB.maxStr = EditorGUILayout.DoubleField("Max Str: ", itemB.maxStr);
            itemB.minStr = EditorGUILayout.DoubleField("Min Str: ", itemB.minStr);

            itemB.maxDex = EditorGUILayout.DoubleField("Max Dex: ", itemB.maxDex);
            itemB.minDex = EditorGUILayout.DoubleField("Min Dex: ", itemB.minDex);

            itemB.maxCon = EditorGUILayout.DoubleField("Max Con: ", itemB.maxCon);
            itemB.minCon = EditorGUILayout.DoubleField("Min Con: ", itemB.minCon);

            itemB.maxInt = EditorGUILayout.DoubleField("Max Int: ", itemB.maxInt);
            itemB.minInt = EditorGUILayout.DoubleField("Min Int: ", itemB.minInt);

            itemB.maxLuc = EditorGUILayout.DoubleField("Max Luc: ", itemB.maxLuc);
            itemB.minLuc = EditorGUILayout.DoubleField("Min Luc: ", itemB.minLuc);

            itemB.maxspeed = EditorGUILayout.DoubleField("Max speed: ", itemB.maxspeed);
            itemB.minspeed = EditorGUILayout.DoubleField("Min speed: ", itemB.minspeed);

            GUILayout.Label("===============================");
        }


        /*if(itemB.genType == ItemBase.GeneratorType.ARMOR)
        {
            itemB.rarity = (ItemBase.RarityType)EditorGUILayout.EnumPopup("Rarity: ", itemB.rarity);

            itemB.item_name = EditorGUILayout.TextField("Item Name: ", itemB.item_name);
            itemB.item_desc = EditorGUILayout.TextField("Item Description: ", itemB.item_desc);
            itemB.item_type = EditorGUILayout.TextField("Item Type: ", itemB.item_type);

            itemB.item_price_buy = EditorGUILayout.IntField("Item Buy Price: ", itemB.item_price_buy);
            itemB.item_price_sell = EditorGUILayout.IntField("Item Sell Price: ", itemB.item_price_sell);
            
            itemB.lvl = EditorGUILayout.IntField("Item lvl: ", itemB.lvl); // level requirement

            itemB.canEquip = EditorGUILayout.Toggle("canEquip: ", itemB.canEquip);
            itemB.canConsume = EditorGUILayout.Toggle("canConsume: ", itemB.canConsume);
            itemB.canSell = EditorGUILayout.Toggle("canSell: ", itemB.canSell);
            
            // GUILayout.Label("Armor"); // Just a lable
            // EditorGUILayout.LabelField("Str: ", itemB.Str.ToString()); // Read Only
            
            itemB.Str = EditorGUILayout.DoubleField("Str: ", itemB.Str);
            itemB.Dex = EditorGUILayout.DoubleField("Dex: ", itemB.Dex);
            itemB.Con = EditorGUILayout.DoubleField("Con: ", itemB.Con);
            itemB.Int = EditorGUILayout.DoubleField("Int: ", itemB.Int);
            itemB.Luc = EditorGUILayout.DoubleField("Luc: ", itemB.Luc);
            itemB.speed = EditorGUILayout.DoubleField("speed: ", itemB.speed);
        }*/

        // Item Generator Function
        
        if(GUILayout.Button("Make Item"))
        {
            itemB.MakeLvLOneWeapon();
            Debug.Log("T");
        }

    }
}
