using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCube : MonoBehaviour
{
    public int CubeHP;
    public TextMeshPro TextCubeHP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextCubeHP.text = CubeHP.ToString();
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.TryGetComponent(out Player player))
    //    {
    //        LoseCubeHP();
    //        player.LoseHP();
    //    }
    //}

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
        }
    }
}
