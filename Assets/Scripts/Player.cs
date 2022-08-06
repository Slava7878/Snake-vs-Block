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

    [SerializeField] private ParticleSystem _bloodSplat;    

    //TailPart tailPart;
    [SerializeField] TailSpawner tailSpawner;
    private AudioSource _splashSound;

    public AudioClip FoodSound;
    [Min(0)]
    public float Volume;

    void Start()
    {
        //tailPart = FindObjectOfType<TailPart>();
        _splashSound = GetComponent<AudioSource>();
    }

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
        //Debug.Log("Losing HP");
        //AudioSource splashSound = GetComponent<AudioSource>();
        _splashSound.Play();

        _bloodSplat.Play();
        
        if (PlayerHP > 0)
        {
            PlayerHP--;
            tailSpawner.LoseTail();            
        }

        if (PlayerHP == 0)
            Die();

        //tailPart.DestroyTail();        
    }

    public void GetFood()
    {
        _splashSound.PlayOneShot(FoodSound, Volume);
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }

    void Update()
    {
        TextHP.text = PlayerHP.ToString();

        //tailPart = FindObjectOfType<TailPart>();
    }
}
