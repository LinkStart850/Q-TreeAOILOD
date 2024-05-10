using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    float v, h = 0;
    public float speed = 10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        if (v != 0 || h != 0)
        {
            //transform.position += Vector3.forward * v * Time.deltaTime * speed;
            transform.Translate(Vector3.forward * v * Time.deltaTime * speed);
            transform.Rotate(Vector3.up * h * Time.deltaTime * speed*10);
        }
    }
}
