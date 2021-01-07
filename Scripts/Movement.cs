using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Movement : MonoBehaviour
{

    public float movementTimer = 1;
    public float movementInterval = 0.35f;
    public GameObject playerGameObject;

    public GameObject UpTileCheck;
    public GameObject DownTileCheck;
    public GameObject LeftTileCheck;
    public GameObject RightTileCheck;
    public Grid grid;
    public Tilemap tilemap;

    public string UpTile;
    public string DownTile;
    public string LeftTile;
    public string RightTile;
    private string TileEndName = " (UnityEngine.Sprite)";
    private string[] bannedTiles = new string[] { "colored_packed_48", "colored_packed_768", "colored_packed_769", "colored_packed_770", "colored_packed_816", "colored_packed_818", "colored_packed_864", "colored_packed_865", "colored_packed_866", "null (UnityEngine.Sprite)" };
    //public List<string> bannedTiles = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        movementTimer = movementInterval;
        //Debug.Log(bannedTiles.ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        movementTimer -= Time.fixedDeltaTime;
        //RightTile = GetSpriteData(RightTile);
        //MovementTimer(RightTile);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Fjern ALT undtagen UpMovement();
            // Så hvis jeg skal lave en Fair test, så skal ALT andet være lukket, og så skal jeg comment det der er nu, og uncomment det der er commented nu.
            if (movementTimer < 0)
            {

                movementTimer = movementInterval;
                UpMovement();
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            DownMovement();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            LeftMovement();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            RightMovement();
        }
    }


    // Måske er det bedre at lave seperate funktioner, hvor if(input.getKey) er i update loopet, og så har man en Up, Down, Left og Right funktion hvor de hvær kalder på hvilken tile der er unden brugerens mål.
    /*void MovementTimer (string RightTileName)
    {
        Debug.Log(RightTileName);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(movementTimer < 0)
            {
                
                if (RightTileName != "null" + TileEndName)
                {
                    transform.position += new Vector3(0, 1, 0);
                    movementTimer = movementInterval;
                }
                else
                {

                }
                
            }
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (movementTimer < 0)
            {
                transform.position += new Vector3(0, -1, 0);
                movementTimer = movementInterval;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (movementTimer < 0)
            {
                transform.position += new Vector3(-1, 0, 0);
                movementTimer = movementInterval;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (movementTimer < 0)
            {
                if (TileChecker(RightTileName))
                {
                    transform.position += new Vector3(1, 0, 0);
                    movementTimer = movementInterval;
                }
            }
        }
    }*/

    private void UpMovement ()
    {
        //if (movementTimer < 0)
        //{
        UpTile = GetSpriteData(UpTile, UpTileCheck);
        //Debug.Log("UpTile: " + UpTile);
        if (TileChecker(UpTile))
            {
                transform.position += new Vector3(0, 1, 0) ;
            //movementTimer = movementInterval;
        }
        //}
    }

    private void DownMovement()
    {
        if (movementTimer < 0)
        {
            DownTile = GetSpriteData(DownTile, DownTileCheck);
            //Debug.Log("DownTile: " + DownTile);
            if (TileChecker(DownTile))
            {
                transform.position += new Vector3(0, -1, 0);
                movementTimer = movementInterval;
            }
        }
    }

    private void LeftMovement()
    {
        if (movementTimer < 0)
        {
            LeftTile = GetSpriteData(LeftTile, LeftTileCheck);
            //Debug.Log("LeftTile: " + LeftTile);
            if (TileChecker(LeftTile))
            {
                transform.position += new Vector3(-1, 0, 0);
                movementTimer = movementInterval;
            }
        }
    }

    private void RightMovement()
    {
        if (movementTimer < 0)
        {
            RightTile = GetSpriteData(RightTile, RightTileCheck);
            //Debug.Log("RightTile: " + RightTile);
            if (TileChecker(RightTile))
            {
                transform.position += new Vector3(1, 0, 0);
                movementTimer = movementInterval;
            }
        }
    }


    public string GetSpriteData(string str, GameObject CheckTileBox)
    {
        Vector3Int coordinate = grid.WorldToCell(CheckTileBox.transform.position);
        //Debug.Log(tilemap.GetSprite(coordinate));

        string tileName = tilemap.GetSprite(coordinate).ToString();
        //Debug.LogWarning("TILENAME: " + tileName);
        str = tileName;
        return str;
    }
    private bool TileChecker(string TileNameInChecker)
    {
        //Debug.LogWarning("HELLO");
        //Debug.LogWarning(bannedTiles.Length);
        bool notBanned = true;
        for (int i = 0; i < bannedTiles.Length; i++)
        {
            //Debug.LogWarning("Tile being checked: " + bannedTiles[i]);
            if (TileNameInChecker == bannedTiles[i] + " (UnityEngine.Sprite)")
            {
                notBanned = false;
                //Debug.LogWarning("Tile: " + bannedTiles[i] + "\t Bool: " + notBanned);
                break;
            }
            else { notBanned = true; }
        }

        return notBanned;
    }

}

/**
 * TODO:
 * [X] lav en liste over BANNED tile sets.
 * [X] sæt en TileChecker up på de resterede sider.
 */