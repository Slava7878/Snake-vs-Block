using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float Speed;
    public Game Game;
    public TextMeshPro TextHP;
    public int PlayerHP;    

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
    }    

    void FixedUpdate()
    {        
        AlwaysMoveForward();
    }

    private void AlwaysMoveForward()
    {
        Rigidbody.velocity = new Vector3(0, 0, Speed);
    }

    public void LoseHP()
    {
        Debug.Log("Losing HP");
        Debug.Log(PlayerHP);
        PlayerHP--;
        Debug.Log(PlayerHP);

        if (PlayerHP <= 0)
            Die();
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }

    void Update()
    {
        TextHP.text = PlayerHP.ToString();
    }    
}
