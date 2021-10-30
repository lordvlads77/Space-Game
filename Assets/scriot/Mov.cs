using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    public float speed;
    float ZMov;
    float XMov;
    public Joystick joystick;
 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        XMov = joystick.Horizontal;
        ZMov = joystick.Vertical;

        transform.position += new Vector3(ZMov, 0f, XMov) * speed * Time.deltaTime;

       
    }
}
