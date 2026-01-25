using UnityEngine;

public class BirdBobbing : MonoBehaviour
{
    public float t;

    public Transform start;
    public Transform end;
    public Transform temp;

    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes a timer that constantly updates variable "t" 
        t += Time.deltaTime;
        //once the timer finishes (or equals 1), it runs the if statement to reset the cycle
        if (t > 1)
        {
            //using a temporary variable to hold the start value, and uses it to switch the start position with the end position
            temp = start;
            start = end;
            end = temp;
            //resets the timer
            t = 0;
        }

        //lerps the object based on the timer position and animation curve in engine
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
