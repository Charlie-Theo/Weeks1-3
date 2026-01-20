using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColour();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame)
        //{
        //    PickARandomColour();
        //}


        //Get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //Check if mouse is over the shape
        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //Y: Set colour (col) variabe
            spriteRenderer.color = col;
        }
        else
        {
            //N: Set colour white
            spriteRenderer.color = Color.yellow;
        }
    }

    void PickARandomColour ()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
