using System.Collections.Generic;
using UnityEngine;

public class TailSpawner : MonoBehaviour
{    
    public GameObject TailPrefab;
    public Player Player;
    public int TailLength { get; set; }

    private List<GameObject> TailParts = new List<GameObject>();
    private List<Vector3> PositionHistory = new List<Vector3>();

    [SerializeField] private int _gap;
    [SerializeField] private float _bodySpeed;

    GameObject tail;    

    void Update()
    {
        if (TailLength < Player.PlayerHP)
        {
            GrowTail();
        }        
    }

    private void FixedUpdate()
    {
        PositionHistory.Insert(0, transform.position);        

        int index = 0;
        
        foreach (var tail in TailParts)
        {
            Vector3 point = PositionHistory[Mathf.Min(index * _gap, PositionHistory.Count - 1)];            

            Vector3 moveDirection = point - tail.transform.position;
            tail.transform.position += moveDirection * _bodySpeed * Time.deltaTime;
            tail.transform.LookAt(point);
            index++;
        }
    }

    private void GrowTail()
    {
        tail = Instantiate(TailPrefab);
        TailParts.Add(tail);
        TailLength++;
    }

    public void LoseTail()
    {
        TailLength--;
        TailParts.RemoveAt(0);
    }
}
