using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailSpawner : MonoBehaviour
{
    //public int TailLength;
    public GameObject TailPrefab;
    public Player Player;
    public int TailLength { get; set; }


    //void Start()
    //{
    //    TailLength = Player.PlayerHP;
    //}

    void Update()
    {
        //TailLength = Player.PlayerHP;
        if (TailLength < Player.PlayerHP)
        {
            GameObject tail = Instantiate(TailPrefab, transform.position + new Vector3(0, 1, -1), Quaternion.identity);
            TailLength++;
        }

        //if (Player.PlayerHP == 1)
        //{
        //    _tailLength = 1;
        //}


        //if (TailLength == Player.PlayerHP) return;

        //if (TailLength > 0)
        //{
        //    GameObject tail = Instantiate(TailPrefab, transform.position + new Vector3(0, 1, -1), Quaternion.identity);            
        //    TailLength--;

        //    if (TailLength == Player.PlayerHP) return;
        //}        
    }
}
