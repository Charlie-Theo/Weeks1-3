using UnityEngine;

public class Searching : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public Transform temp;
    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            temp = start;
            start = end;
            end = temp;
            t = 0;
        }

        transform.position = Vector2.Lerp(start.position, end.position, t);
    }
}
