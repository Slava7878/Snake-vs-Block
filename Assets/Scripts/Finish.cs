using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private ParticleSystem _salut;
    private AudioSource _gameMusic;
    [SerializeField] private float _gameMusicDelay;

    public AudioClip FinishSound;
    [Min(0)]
    public float Volume;

    private void Start()
    {
        _gameMusic = GetComponent<AudioSource>();
        _gameMusic.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Player player)) return;

        _gameMusic.Stop();
        _gameMusic.PlayOneShot(FinishSound, Volume);
        _salut.Play();
        player.ReachFinish();
        _gameMusic.PlayDelayed(_gameMusicDelay);
    }
}
