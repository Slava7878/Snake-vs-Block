using UnityEngine;
using TMPro;

public class Food : MonoBehaviour
{
    [SerializeField] private int _minFoodAmount;
    [SerializeField] private int _maxFoodAmount;
    [SerializeField] private TextMeshPro _textFoodAmount;
    private int _foodAmount;    

    private void Awake()
    {
        _foodAmount = Random.Range(_minFoodAmount, _maxFoodAmount);
    }

    void Start()
    {
        _textFoodAmount.text = _foodAmount.ToString();
    }    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
        {
            player.GetFood();
            player.PlayerHP += _foodAmount;
            _foodAmount = 0;

            if (_foodAmount <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
