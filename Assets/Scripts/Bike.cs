using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

public class Bike : MonoBehaviour
{
    public float velocity;
    public bool isRunning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isRunning)
        {
            Move(velocity * Time.deltaTime);
        }
    }

    public void Move(float distance)
    {
        transform.position += new Vector3(distance, 0, 0);
    }

    public void SetPosition2D(float xPos)
    {
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
