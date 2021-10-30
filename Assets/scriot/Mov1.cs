using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov1 : MonoBehaviour
{
    public float speed;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            joystick.transform.Translate(0, 0, 1 * Time.deltaTime * speed);
        }

        if (Input.touchCount > 0)
        {
            joystick.transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.touchCount > 0)
        {
            joystick.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.touchCount > 0)
        {
            joystick.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.touchCount > 0)
        {
            joystick.transform.Rotate(0, -1, 0 * Time.deltaTime * 2);
        }


        if (Input.touchCount > 0)
        {
            joystick.transform.Rotate(0, 1, 0 * Time.deltaTime * 2);

        }
    }
}
