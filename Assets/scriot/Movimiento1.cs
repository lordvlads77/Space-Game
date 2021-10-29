using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento1 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 1 * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0 * Time.deltaTime * 2);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0 * Time.deltaTime * 2);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }


        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }
    }
}
