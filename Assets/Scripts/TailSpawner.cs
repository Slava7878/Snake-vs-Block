using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailSpawner : MonoBehaviour
{
    public int TailLength;
    public GameObject TailPrefab;
    public Player Player;


    void Start()
    {
        TailLength = Player.PlayerHP;
    }
    
    void Update()
    {        
        if (TailLength > 0)
        {
            GameObject tail = Instantiate(TailPrefab, transform.position, Quaternion.identity);            
            TailLength--;
        }
    }
}
