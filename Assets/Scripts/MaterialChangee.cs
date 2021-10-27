using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChangee : MonoBehaviour
{
    
    public Material[] materialss;
    private Renderer rends;

    int RandMaterialss;
    //public float RandomAgainn;
    //int randommats2;


    // Start is called before the first frame update
    void Start()
    {

       rends = GetComponent<Renderer>();
        rends.enabled = true;
        
        

        RandMaterialss = Random.Range(0, 4);
        rends.sharedMaterial = materialss[RandMaterialss];
        //RandomAgainn = Random.value;
        
        if (RandMaterialss == 4)
        {

            rends.sharedMaterial = materialss[4];

        }
        
        if (RandMaterialss == 3)
        {

            rends.sharedMaterial = materialss[3];

        }

        if (RandMaterialss == 2)
        {

            rends.sharedMaterial = materialss[2];
        }

        if (RandMaterialss == 1)
        {

            rends.sharedMaterial = materialss[1];

        }

        if (RandMaterialss == 0)
        {

            rends.sharedMaterial = materialss[0];

        }

        
    }

    private void Update()
    {
    }

    
    
}
