using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    //public Rigidbody Player;
    public float Sensitivity;
    //Vector3 initialPosition;
    //private float _distance;

    public Transform PlayerObj;
    public float Speed;
    //public Rigidbody PlayerObj;
    //public float ForwardSpeed;
    //public float SideSpeed;
    //private float? lastMousePoint = null;

    public bool IsLeftPressed = false;
    public bool IsRightPressed = false;

    void FixedUpdate()
    {
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    initialPosition = transform.position;
        //    Vector3 rayPoint = ray.GetPoint(0);
        //    _distance = Vector3.Distance(transform.position, rayPoint);
        //}

        //if (Input.GetMouseButton(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    Vector3 rayPoint = ray.GetPoint(_distance * Sensitivity);
        //    Player.MovePosition(initialPosition + new Vector3(rayPoint.x, 0, 0));
        //}

        if (Input.GetKey(KeyCode.A))
        {
            MoveToLeft();
            //PlayerObj.position += -PlayerObj.right * (Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            MoveToRight();
            //PlayerObj.position += PlayerObj.right * (Time.deltaTime * Speed);
        }

        if (IsLeftPressed)
        {
            MoveToLeft();
        }

        else if (!IsLeftPressed)
        {

            //Your Code Here
        }

        if (IsRightPressed)
        {
            MoveToRight();
        }

        //if (Input.GetMouseButtonDown(0))
        //{
        //    float sideMovement = Input.GetAxis("Mouse X") * Speed;
        //    sideMovement *= Time.deltaTime;
        //    transform.Translate(sideMovement, 0, 0);
        //}

        //if (Input.GetAxis("Mouse X") < 0)
        //{
        //    float sideMovement = Input.GetAxis("Mouse X") * Speed * Time.deltaTime;
        //    transform.Translate(-sideMovement, 0, 0);
        //}
        //else if (Input.GetAxis("Mouse X") > 0)
        //{
        //    float sideMovement = Input.GetAxis("Mouse X") * Speed * Time.deltaTime;
        //    transform.Translate(sideMovement, 0, 0);
        //}

        //if (Input.GetMouseButtonDown(0))
        //{
        //    lastMousePoint = Input.mousePosition.x;
        //}
        //else if (Input.GetMouseButtonUp(0))
        //{
        //    lastMousePoint = null;
        //}
        //if (lastMousePoint != null)
        //{
        //    float difference = Input.mousePosition.x - lastMousePoint.Value;
        //    transform.position = new Vector3(transform.position.x + difference * Time.deltaTime, 0, 0);
        //    lastMousePoint = Input.mousePosition.x;
        //}

        
    }

    public void MoveToLeft()
    {
        PlayerObj.position += -PlayerObj.right * (Time.deltaTime * Speed);
    }

    public void MoveToRight()
    {
        PlayerObj.position += PlayerObj.right * (Time.deltaTime * Speed);
    }

    public void onPointerDownLeftButton()
    {
        IsLeftPressed = true;
    }
    public void onPointerUpLeftButton()
    {
        IsLeftPressed = false;
    }

    public void onPointerDownRightButton()
    {
        IsRightPressed = true;
    }
    public void onPointerUpRightButton()
    {
        IsRightPressed = false;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float mouseAxis = Input.GetAxis("Mouse X");
            if (mouseAxis < 0)
                MouseMoveToLeft();
            if (mouseAxis > 0)
                MouseMoveToRight();
        }
    }

    public void MouseMoveToLeft()
    {
        PlayerObj.position += -PlayerObj.right * (Time.deltaTime * Speed * Sensitivity);
    }

    public void MouseMoveToRight()
    {
        PlayerObj.position += PlayerObj.right * (Time.deltaTime * Speed * Sensitivity);
    }

    //void Start()
    //{        
    //    PlayerObj = GetComponent<Rigidbody>();
    //}

    //void FixedUpdate()
    //{
    //    Vector3 m_Input = new Vector3(0, 0, 1);
    //    Vector3 left = new Vector3(-1, 0, 0);
    //    Vector3 right = new Vector3(1, 0, 0);
    //    //Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, 3);        

    //    //PlayerObj.MovePosition(transform.position + m_Input * Time.deltaTime);
    //    PlayerObj.MovePosition(transform.position + m_Input * Time.deltaTime * ForwardSpeed);

    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        PlayerObj.MovePosition(transform.position + left * Time.deltaTime * SideSpeed);
    //    }

    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        PlayerObj.MovePosition(transform.position + right * Time.deltaTime * SideSpeed);
    //    }
    //}
}
