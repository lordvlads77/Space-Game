using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Planets;
    public Vector3 spawnValues;
    public float spawnWait;
    public float startwait;
    //public float PlanetsMostWait;
    public float PlanetsLeastWait;
    public bool stop;
    public int StopSpawningTimer;

    int randPlanet;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spanweador());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = 1;


        StopSpawningTimer = Time.frameCount;

    }

    private void LateUpdate()
    {
        if (StopSpawningTimer == 515)
        {
            stop = true;
            StopCoroutine(Spanweador());
        }


    }

    IEnumerator Spanweador()
    {
        yield return new WaitForSeconds(startwait);

        while(!stop)
        {
            randPlanet = Random.Range(0, 1);
            Vector3 spawnPlace = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 4, Random.Range(-spawnValues.z, spawnValues.z));

            Instantiate(Planets[randPlanet], spawnPlace + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
            
        }
    }

   
}
