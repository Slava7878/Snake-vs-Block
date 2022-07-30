using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCube : MonoBehaviour
{
    public int CubeHP;
    public TextMeshPro TextCubeHP;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();        
    }
    
    void Update()
    {
        TextCubeHP.text = CubeHP.ToString();
        rend.material.SetFloat("_EnemyHealth", CubeHP);
    }    

    private void LoseCubeHP()
    {        
        CubeHP--;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
        {            
            if (player.PlayerHP >= 0)
            {
                LoseCubeHP();
                player.LoseHP();
            }

            if (CubeHP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
