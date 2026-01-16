using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public float speed = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRot = transform.eulerAngles;
        newRot.z += speed * Time.deltaTime;
        transform.eulerAngles = newRot;
    }
}
