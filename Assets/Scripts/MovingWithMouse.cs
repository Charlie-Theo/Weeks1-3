using UnityEngine;
using UnityEngine.InputSystem;

public class MovingWithMouse : MonoBehaviour
{
    public Vector2 newPos;

    Vector2 mousePos;
    Vector2 currentMousePos;

    public float rangeTop = 0.5f;
    public float rangeBottom = -0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gets the mouse position and translates it to the world position
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        currentMousePos = mousePos;
        newPos = transform.position;

        //checks if the mouse is in the top half or bottom half of the screen
        if (mousePos.y < Screen.height)
        {
            //divides the mouse position and then adds it to the current position
            //this keeps the object's movement range small
            currentMousePos.y = currentMousePos.y / 60;
            newPos.y += currentMousePos.y;

            //makes sure the object cannot leave a specific range
            if (newPos.y > rangeTop)
            {
                newPos.y = rangeTop - 0.1f;
            }
            if (newPos.y < rangeBottom)
            {
                newPos.y = rangeBottom + 0.1f;
            }
        }
        else if (mousePos.y < Screen.height / 2)
        {
            //divides the mouse position and then subtracts it to the current position
            //this keeps the object's movement range small
            currentMousePos.y = currentMousePos.y / 60;
            newPos.y -= currentMousePos.y;

            //makes sure the object cannot leave a specific range
            if (newPos.y > rangeTop)
            {
                newPos.y = rangeTop - 0.1f;
            }
            if (newPos.y < rangeBottom)
            {
                newPos.y = rangeBottom + 0.1f;
            }
        }

        transform.position = newPos;
    }
}
