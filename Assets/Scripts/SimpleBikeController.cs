using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBikeController : MonoBehaviour
{
    public float speed;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            cam.transform.position -= new Vector3(0, 4 * Time.deltaTime, 0);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            cam.transform.position += new Vector3(0, 4 * Time.deltaTime, 0);
        }
    }
}
