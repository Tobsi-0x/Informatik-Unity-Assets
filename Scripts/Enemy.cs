using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    //public GameObject EnemyObj;// = GameObject.Find("Enemy");
    public GameObject ThisEnemy;

    // Start is called before the first frame update
    void Start()
    {
        ThisEnemy = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyMove(GameObject[] EnemyObj)
    {
        foreach(GameObject Enm in EnemyObj)
        {
            Enm.transform.position += new Vector3(0, -1, 0);
        }
        

    }
    public void EnemyMoveSelf()
    {
        ThisEnemy.transform.position += new Vector3(0, -1, 0);
    }

    private bool CheckObsticle()
    {
        // Kan bruge min TileChecker funktion, men der er flere fjender. måske er der en bedre løsning.
        // EmptyGameOBJ?
        // 
        // Hvis jeg kan finde en måde at få hvilken sprite der er på position (X; Y) så kan jeg bare sende min "kommende" kordinater og se om det er muligt.


        return true;
    }

    /** // AI //
     * 
     * AI, tenker på at bruge A* (AStar search algorithm)
     * 
     * StateMachine:
     *      Hvis der ikke er nogen fjender (spilleren) så går den i en tilfældig retning.
     *      Fjende inden for radius (cirkel) ANGRIB!!! [Bruger A* pathfinding]
     * 
     * 
     */

}
