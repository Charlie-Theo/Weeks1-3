using UnityEngine;

public class MovingDestination : MonoBehaviour
{
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
            transform.position = new Vector2(Random.Range(-10, 10), Random.Range(-5, 5));
            t = 0;
        }
    }
}
