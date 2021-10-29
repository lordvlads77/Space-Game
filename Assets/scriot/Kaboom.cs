using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaboom : MonoBehaviour
{
    public GameObject planeta1;
    public GameObject planeta2;
    public GameObject planeta3;
    public GameObject planeta4;
    public GameObject planeta5;

    public GameObject Bomba1;
    public GameObject Bomba2;

    public MeshRenderer bomba1;
    public MeshRenderer bomba2;

    public float distancia1;
    public float distancia2;
    public float distancia3;
    public float distancia4;
    public float distancia5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia1 = Vector3.Distance(planeta1.transform.position, transform.position);
        distancia2 = Vector3.Distance(planeta2.transform.position, transform.position);
        distancia3 = Vector3.Distance(planeta3.transform.position, transform.position);
        distancia4 = Vector3.Distance(planeta4.transform.position, transform.position);
        distancia5 = Vector3.Distance(planeta5.transform.position, transform.position);

        if (distancia1 <= 5 && Bomba1.transform.position == planeta1.transform.position)
        {
            bomba1.enabled = true;
        }

        if(distancia1 <= 5 && Bomba2.transform.position == planeta1.transform.position)
        {
            bomba2.enabled = true;
        }
//****************************************************************************************************************

        if(distancia2 <= 5 && Bomba1.transform.position == planeta2.transform.position)
        {
            bomba1.enabled = true;
        }

        if (distancia2 <= 5 && Bomba2.transform.position == planeta2.transform.position)
        {
            bomba2.enabled = true;
        }
//****************************************************************************************************************

        if (distancia3 <= 5 && Bomba1.transform.position == planeta3.transform.position)
        {
            bomba1.enabled = true;
        }

        if (distancia3 <= 5 && Bomba2.transform.position == planeta3.transform.position)
        {
            bomba2.enabled = true;
        }
//*****************************************************************************************************************

        if (distancia4 <= 5 && Bomba1.transform.position == planeta4.transform.position)
        {
            bomba1.enabled = true;
        }

        if (distancia4 <= 5 && Bomba2.transform.position == planeta4.transform.position)
        {
            bomba2.enabled = true;
        }
//******************************************************************************************************************

        if (distancia5 <= 5 && Bomba1.transform.position == planeta5.transform.position)
        {
            bomba1.enabled = true;
        }

        if (distancia5 <= 5 && Bomba2.transform.position == planeta5.transform.position)
        {
            bomba2.enabled = true;
        }
    }
}
