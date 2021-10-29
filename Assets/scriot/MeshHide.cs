using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshHide : MonoBehaviour
{
    public GameObject trigger;
     void Start()
    {
        trigger.SetActive(false);
    }
    void Update()
    {

    }

    public void showMesh()
    {

        trigger.SetActive(true);
        

    }

   

}
