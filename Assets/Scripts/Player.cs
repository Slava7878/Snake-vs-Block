using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody _playerRigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private Game _game;    

    [SerializeField] private TextMeshPro _textHP;
    [SerializeField] private ParticleSystem _bloodSplat;    
    [SerializeField] TailSpawner tailSpawner;
    [SerializeField] Score score;

    private AudioSource _splashSound;
    private bool _isAlive = true;

    public int PlayerHP;

    public AudioClip FoodSound;
    [Min(0)]
    public float Volume;

    void Start()
    {        
        _splashSound = GetComponent<AudioSource>();
    }

    public void ReachFinish()
    {
        _game.OnPlayerReachedFinish();
        _playerRigidbody.velocity = Vector3.zero;
    }

    void FixedUpdate()
    {
        if (_isAlive)
            AlwaysMoveForward();
    }

    private void AlwaysMoveForward()
    {
        _playerRigidbody.velocity = new Vector3(0, 0, _speed);
    }

    public void LoseHP()
    {        
        _splashSound.Play();
        _bloodSplat.Play();
        
        if (PlayerHP > 0)
        {
            PlayerHP--;
            score.AddScore();
            tailSpawner.LoseTail();
        }

        if (PlayerHP == 0)
            Die();                
    }

    public void GetFood()
    {
        _splashSound.PlayOneShot(FoodSound, Volume);
    }

    public void Die()
    {
        _isAlive = false;
        _playerRigidbody.velocity = Vector3.zero;
        _game.OnPlayerDied();        
    }

    void Update()
    {
        _textHP.text = PlayerHP.ToString();        
    }
}
