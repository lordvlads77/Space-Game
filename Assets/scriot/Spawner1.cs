using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject planeta1;
    public GameObject planeta2;
    public GameObject planeta3;
    public GameObject planeta4;
    public GameObject planeta5;

    private float posRandX1;
    private float posRandX2;
    private float posRandX3;
    private float posRandX4;
    private float posRandX5;

    // Start is called before the first frame update
    void Start()
    {   
        posRandX1 = Random.Range(-64, 64);
        planeta1.transform.position = new Vector3(posRandX1, 3, 64);

        posRandX2 = Random.Range(-64, 64);
        planeta2.transform.position = new Vector3(posRandX2, 3, 32);

        posRandX3 = Random.Range(-64, 64);
        planeta3.transform.position = new Vector3(posRandX3, 3, 0);

        posRandX4 = Random.Range(-64, 64);
        planeta4.transform.position = new Vector3(posRandX4, 3, -32);

        posRandX5 = Random.Range(-64, 64);
        planeta5.transform.position = new Vector3(posRandX5, 3, -64);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
