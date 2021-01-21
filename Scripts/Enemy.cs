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
}
