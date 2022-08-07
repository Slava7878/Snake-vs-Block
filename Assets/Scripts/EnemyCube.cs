using UnityEngine;
using TMPro;

public class EnemyCube : MonoBehaviour
{
    [SerializeField] private int _minCubeHP;
    [SerializeField] private int _maxCubeHP;

    private int _cubeHP;
    [SerializeField] private TextMeshPro _textCubeHP;

    Renderer rend;

    private void Awake()
    {
        _cubeHP = Random.Range(_minCubeHP, _maxCubeHP);
    }

    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    
    void Update()
    {
        _textCubeHP.text = _cubeHP.ToString();
        rend.material.SetFloat("_EnemyHealth", _cubeHP);
    }

    private void LoseCubeHP()
    {
        _cubeHP--;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
        {
            if (player.PlayerHP > 0)
            {
                LoseCubeHP();
                player.LoseHP();
            }

            if (_cubeHP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }    
}
