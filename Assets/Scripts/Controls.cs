using UnityEngine;

public class Controls : MonoBehaviour
{    
    [SerializeField] private float _sensitivity;
    [SerializeField] private float _speed;

    public Transform PlayerObj;        

    public bool IsLeftPressed = false;
    public bool IsRightPressed = false;

    void FixedUpdate()
    {        
        if (Input.GetKey(KeyCode.A))
        {
            MoveToLeft();            
        }

        if (Input.GetKey(KeyCode.D))
        {
            MoveToRight();            
        }

        if (IsLeftPressed)
        {
            MoveToLeft();
        }        

        if (IsRightPressed)
        {
            MoveToRight();
        }        
    }

    public void MoveToLeft()
    {
        PlayerObj.position += -PlayerObj.right * (Time.deltaTime * _speed);
    }

    public void MoveToRight()
    {
        PlayerObj.position += PlayerObj.right * (Time.deltaTime * _speed);
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

    public void MouseMoveToLeft()
    {
        PlayerObj.position += -PlayerObj.right * (Time.deltaTime * _sensitivity);
    }

    public void MouseMoveToRight()
    {
        PlayerObj.position += PlayerObj.right * (Time.deltaTime * _sensitivity);
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
}
