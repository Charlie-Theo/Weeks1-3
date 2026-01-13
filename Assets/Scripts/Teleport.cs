using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float time;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 3)
        {
            transform.position = new Vector2(Random.Range(-7, 7), Random.Range(-5, 5));
            time = 0;
        }
    }
}
