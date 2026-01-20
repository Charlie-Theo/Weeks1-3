using UnityEngine;
using UnityEngine.InputSystem;

public class TankMovement : MonoBehaviour
{
    public bool leftArrowIsPressed = false;
    public bool rightArrowIsPressed = false;

    public float speed = 4;

    Vector2 newPos;
    Vector2 screenPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftArrowIsPressed = Keyboard.current.leftArrowKey.isPressed;
        rightArrowIsPressed = Keyboard.current.rightArrowKey.isPressed;

        screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (leftArrowIsPressed == true && screenPos.x > 0) 
        {
            newPos = transform.position;
            newPos.x -= speed * Time.deltaTime;
            transform.position = newPos;
        } else if (rightArrowIsPressed == true && screenPos.x < Screen.width)
        {
            newPos = transform.position;
            newPos.x += speed * Time.deltaTime;
            transform.position = newPos;
        }
    }
}
