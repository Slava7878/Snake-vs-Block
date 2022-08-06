using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailSpawner : MonoBehaviour
{
    //public int TailLength;
    public GameObject TailPrefab;
    public Player Player;
    public int TailLength { get; set; }

    private List<GameObject> TailParts = new List<GameObject>();
    private List<Vector3> PositionHistory = new List<Vector3>();

    [SerializeField] private int _gap;
    [SerializeField] private float _bodySpeed;

    GameObject tail;
    TailPart tailPart;

    void Start()
    {
        //GrowTail();
        //TailLength = 0;
    }

    void Update()
    {
        //TailLength = Player.PlayerHP;

        if (TailLength < Player.PlayerHP)
        {
            GrowTail();
        }

        //if (TailLength > Player.PlayerHP)
        //{
        //    LoseTail();
        //    TailLength--;
        //}

        //if (Player.PlayerHP == 1)
        //{
        //    _tailLength = 1;
        //}


        //if (TailLength == Player.PlayerHP) return;

        //if (TailLength > 0)
        //{
        //    GameObject tail = Instantiate(TailPrefab, transform.position + new Vector3(0, 1, -1), Quaternion.identity);            
        //    TailLength--;

        //    if (TailLength == Player.PlayerHP) return;
        //}        
    }

    private void FixedUpdate()
    {
        PositionHistory.Insert(0, transform.position);

        

        int index = 0;
        
        foreach (var tail in TailParts)
        {
            Vector3 point = PositionHistory[Mathf.Min(index * _gap, PositionHistory.Count - 1)];
            //Vector3 point = PositionHistory[Mathf.Min(TailLength * _gap, PositionHistory.Count - 1)];

            Vector3 moveDirection = point - tail.transform.position;
            tail.transform.position += moveDirection * _bodySpeed * Time.deltaTime;
            tail.transform.LookAt(point);
            index++;
            //TailLength++;
        }
    }

    private void GrowTail()
    {
        //GameObject tail = Instantiate(TailPrefab, transform.position + new Vector3(0, 1, -1), Quaternion.identity);

        //GameObject tail = Instantiate(TailPrefab);
        tail = Instantiate(TailPrefab);
        TailParts.Add(tail);
        TailLength++;
    }

    public void LoseTail()
    {
        TailLength--;
        TailParts.RemoveAt(0);
        //Destroy(tail);
        //tailPart.DestroyTail();
    }
}
