using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Texture : MonoBehaviour
{
    public Material camo1;
    public Material camo2;
    public Material camo3;
    public Material camo4;
    public Material camo5;

    public GameObject planeta1;
    public GameObject planeta2;
    public GameObject planeta3;
    public GameObject planeta4;
    public GameObject planeta5;

    public GameObject Oro;
    public GameObject Oro2;

    public GameObject Bomba;
    public GameObject Bomba2;

    public List<int> pilaEnteros = new List<int> { 1, 2, 3, 4, 5 };
    // Start is called before the first frame update
    void Start()
    {
        var shuffle = pilaEnteros.OrderBy(x => System.Guid.NewGuid()).ToList();
        
        if(shuffle[0] == 1)
        {
            planeta1.GetComponent<Renderer>().material = camo1;
            float posX1 = planeta1.transform.position.x;
            float posZ1 = planeta1.transform.position.z;
            Oro.transform.position = new Vector3(posX1, 3, posZ1);
        }

        if (shuffle[0] == 2)
        {
            planeta1.GetComponent<Renderer>().material = camo2;
            float posX1 = planeta1.transform.position.x;
            float posZ1 = planeta1.transform.position.z;
            Bomba.transform.position = new Vector3(posX1, 3, posZ1);
        }

        if (shuffle[0] == 3)
        {
            planeta1.GetComponent<Renderer>().material = camo3;
        }

        if (shuffle[0] == 4)
        {
            planeta1.GetComponent<Renderer>().material = camo4;
            float posX1 = planeta1.transform.position.x;
            float posZ1 = planeta1.transform.position.z;
            Bomba2.transform.position = new Vector3(posX1, 3, posZ1);
        }
        if (shuffle[0] == 5)
        {
            planeta1.GetComponent<Renderer>().material = camo5;
            float posX1 = planeta1.transform.position.x;
            float posZ1 = planeta1.transform.position.z;
            Oro2.transform.position = new Vector3(posX1, 3, posZ1);
        }


        if(shuffle[1] == 1)
        {
            planeta2.GetComponent<Renderer>().material = camo1;
            float posX2 = planeta2.transform.position.x;
            float posZ2 = planeta2.transform.position.z;
            Oro.transform.position = new Vector3(posX2, 3, posZ2);
        }

        if (shuffle[1] == 2)
        {
            planeta2.GetComponent<Renderer>().material = camo2;
            float posX2 = planeta2.transform.position.x;
            float posZ2 = planeta2.transform.position.z;
            Bomba.transform.position = new Vector3(posX2, 3, posZ2);
        }

        if (shuffle[1] == 3)
        {
            planeta2.GetComponent<Renderer>().material = camo3;
        }

        if (shuffle[1] == 4)
        {
            planeta2.GetComponent<Renderer>().material = camo4;
            float posX2 = planeta2.transform.position.x;
            float posZ2 = planeta2.transform.position.z;
            Bomba2.transform.position = new Vector3(posX2, 3, posZ2);
        }
        if (shuffle[1] == 5)
        {
            planeta2.GetComponent<Renderer>().material = camo5;
            float posX2 = planeta2.transform.position.x;
            float posZ2 = planeta2.transform.position.z;
            Oro2.transform.position = new Vector3(posX2, 3, posZ2);
        }


        if(shuffle[2] == 1)
        {
            planeta3.GetComponent<Renderer>().material = camo1;
            float posX3 = planeta3.transform.position.x;
            float posZ3 = planeta3.transform.position.z;
            Oro.transform.position = new Vector3(posX3, 3, posZ3);
        }

        if (shuffle[2] == 2)
        {
            planeta3.GetComponent<Renderer>().material = camo2;
            float posX3 = planeta3.transform.position.x;
            float posZ3 = planeta3.transform.position.z;
            Bomba.transform.position = new Vector3(posX3, 3, posZ3);
        }

        if (shuffle[2] == 3)
        {
            planeta3.GetComponent<Renderer>().material = camo3;
        }

        if (shuffle[2] == 4)
        {
            planeta3.GetComponent<Renderer>().material = camo4;
            float posX3 = planeta3.transform.position.x;
            float posZ3 = planeta3.transform.position.z;
            Bomba2.transform.position = new Vector3(posX3, 3, posZ3);
        }
        if (shuffle[2] == 5)
        {
            planeta3.GetComponent<Renderer>().material = camo5;
            float posX3 = planeta3.transform.position.x;
            float posZ3 = planeta3.transform.position.z;
            Oro2.transform.position = new Vector3(posX3, 3, posZ3);
        }


        if(shuffle[3] == 1)
        {
            planeta4.GetComponent<Renderer>().material = camo1;
            float posX4 = planeta4.transform.position.x;
            float posZ4 = planeta4.transform.position.z;
            Oro.transform.position = new Vector3(posX4, 3, posZ4);
        }

        if (shuffle[3] == 2)
        {
            planeta4.GetComponent<Renderer>().material = camo2;
            float posX4 = planeta4.transform.position.x;
            float posZ4 = planeta4.transform.position.z;
            Bomba.transform.position = new Vector3(posX4, 3, posZ4);
        }

        if (shuffle[3] == 3)
        {
            planeta4.GetComponent<Renderer>().material = camo3;
        }

        if (shuffle[3] == 4)
        {
            planeta4.GetComponent<Renderer>().material = camo4;
            float posX4 = planeta4.transform.position.x;
            float posZ4 = planeta4.transform.position.z;
            Bomba2.transform.position = new Vector3(posX4, 3, posZ4);
        }
        if (shuffle[3] == 5)
        {
            planeta4.GetComponent<Renderer>().material = camo5;
            float posX4 = planeta4.transform.position.x;
            float posZ4 = planeta4.transform.position.z;
            Oro2.transform.position = new Vector3(posX4, 3, posZ4);
        }


        if(shuffle[4] == 1)
        {
            planeta5.GetComponent<Renderer>().material = camo1;
            float posX5 = planeta5.transform.position.x;
            float posZ5 = planeta5.transform.position.z;
            Oro.transform.position = new Vector3(posX5, 3, posZ5);
        }

        if (shuffle[4] == 2)
        {
            planeta5.GetComponent<Renderer>().material = camo2;
            float posX5 = planeta5.transform.position.x;
            float posZ5 = planeta5.transform.position.z;
            Bomba.transform.position = new Vector3(posX5, 3, posZ5);
        }

        if (shuffle[4] == 3)
        {
            planeta5.GetComponent<Renderer>().material = camo3;
        }

        if (shuffle[4] == 4)
        {
            planeta5.GetComponent<Renderer>().material = camo4;
            float posX5 = planeta5.transform.position.x;
            float posZ5 = planeta5.transform.position.z;
            Bomba2.transform.position = new Vector3(posX5, 3, posZ5);
        }
        if (shuffle[4] == 5)
        {
            planeta5.GetComponent<Renderer>().material = camo5;
            float posX5 = planeta5.transform.position.x;
            float posZ5 = planeta5.transform.position.z;
            Oro2.transform.position = new Vector3(posX5, 3, posZ5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
