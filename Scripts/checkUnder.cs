using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class checkUnder : MonoBehaviour
{
    public Grid grid;
    public Tilemap tilemap;

    //public string TileName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        /*Vector3Int lPos = grid.WorldToCell(player.transform.position);
        Debug.Log("name : " + tilemap.GetTile(lPos).name + " & position : " + lPos);*/

        Vector3Int coordinate = grid.WorldToCell(transform.position);
        Debug.Log(tilemap.GetSprite(coordinate));

        string tileName = tilemap.GetSprite(coordinate).ToString();

        Debug.LogWarning(tileName);
    }

    public string GetSpriteData()
    {
        Vector3Int coordinate = grid.WorldToCell(transform.position);
        Debug.Log(tilemap.GetSprite(coordinate));

        string tileName = tilemap.GetSprite(coordinate).ToString();

        return tileName;
    }
}
