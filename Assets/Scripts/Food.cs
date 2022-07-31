using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Food : MonoBehaviour
{
    [SerializeField] private int _minFoodAmount;
    [SerializeField] private int _maxFoodAmount;

    private int _foodAmount;

    public TextMeshPro TextFoodAmount;

    private void Awake()
    {
        _foodAmount = Random.Range(_minFoodAmount, _maxFoodAmount);
    }

    void Start()
    {
        
    }
    
    void Update()
    {
        TextFoodAmount.text = _foodAmount.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
        {
            player.PlayerHP += _foodAmount;
            _foodAmount = 0;

            if (_foodAmount <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
