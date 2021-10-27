using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    public Material[] materials;
    private Renderer rend;


     
    public float RandMat1;
   
   
    

    // Start is called before the first frame update
    void Start()
    {

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        RandMat1 = Time.deltaTime;
      
    }

    // Update is called once per frame
    void Update()
    {
       
       
        if (RandMat1 > 0.2)
        {
            rend.sharedMaterial = materials[0];
            Debug.Log("cumplido mayor 0.00");
        }
        else if (RandMat1 > 0.0068)
        {
            rend.sharedMaterial = materials[1];
            Debug.Log("cumplido mayor 0.0068");
        }

        if (RandMat1 > 0.0075)
        {
            rend.sharedMaterial = materials[2];
            Debug.Log("cumplido mayor 0.0075");
        }
        else if (RandMat1 > 0.0077)
        {
            rend.sharedMaterial = materials[3];
            Debug.Log("cumplido mayor 0.0075");
        }
        else if(RandMat1 > 0.008000)
        {
            rend.sharedMaterial = materials[3];
            Debug.Log("Holo 0.0080"); 
        }
        if (RandMat1 > 0.0090000)
        {
            rend.sharedMaterial = materials[3];
           
        }
        else if (RandMat1 > 0.00950000)
        {
            rend.sharedMaterial = materials[0];
            
        }
        if (RandMat1 > 0.0100)
        {
            rend.sharedMaterial = materials[4];
            Debug.Log("0.0100");
        }



        
        
        
    }

    private void LateUpdate()
    {
        /*if (RandMat2 == 50)
        {
            rend.sharedMaterial = materials[0];
            Debug.Log("0mat");
            Debug.ClearDeveloperConsole();

            if (RandMat2 == 400)
            {
                rend.sharedMaterial = materials[1];
                Debug.Log("0mat");
                Debug.ClearDeveloperConsole();

                if (RandMat2 == 800)
                {
                    rend.sharedMaterial = materials[2];
                    Debug.Log("0mat");
                    Debug.ClearDeveloperConsole();
                    if (RandMat2 == 1200)
                    {
                        rend.sharedMaterial = materials[3];
                        Debug.Log("0mat");
                        Debug.ClearDeveloperConsole();

                    }


                }
            }
            
            

        }*/
        
       
    }

    
}
