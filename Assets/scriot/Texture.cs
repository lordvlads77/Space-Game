using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Texture : MonoBehaviour
{
    // Finishing the Conditionals for applying the texture
    public Material camo1;
    public Material camo2;
    public Material camo3;
    public Material camo4;
    public Material camo5;
    public Material SurpriseTex;
    public Material RewardTex;

    public GameObject planeta1;
    public GameObject planeta2;
    public GameObject planeta3;
    public GameObject planeta4;
    public GameObject planeta5;
    public GameObject Surprise;
    public GameObject Surprise2;
    public GameObject Surprise3;
    public GameObject Surprise4;
    public GameObject Surprise5;


    public List<int> pilaEnteros = new List<int> { 1, 2, 3, 4, 5 };
    public List<int> pilaEnteros1 = new List<int> { 1, 2, 3, 4, 5};
    // Start is called before the first frame update
    void Start()
    {
        var shuffle = pilaEnteros.OrderBy(x => System.Guid.NewGuid()).ToList();
        
        if(shuffle[0] == 1)
        {
            planeta1.GetComponent<Renderer>().material = camo1;
        }

        if (shuffle[0] == 2)
        {
            planeta1.GetComponent<Renderer>().material = camo2;
        }

        if (shuffle[0] == 3)
        {
            planeta1.GetComponent<Renderer>().material = camo3;
        }

        if (shuffle[0] == 4)
        {
            planeta1.GetComponent<Renderer>().material = camo4;
        }
        if (shuffle[0] == 5)
        {
            planeta1.GetComponent<Renderer>().material = camo5;
        }


        if(shuffle[1] == 1)
        {
            planeta2.GetComponent<Renderer>().material = camo1;
        }

        if (shuffle[1] == 2)
        {
            planeta2.GetComponent<Renderer>().material = camo2;
        }

        if (shuffle[1] == 3)
        {
            planeta2.GetComponent<Renderer>().material = camo3;
        }

        if (shuffle[1] == 4)
        {
            planeta2.GetComponent<Renderer>().material = camo4;
        }
        if (shuffle[1] == 5)
        {
            planeta2.GetComponent<Renderer>().material = camo5;
        }


        if(shuffle[2] == 1)
        {
            planeta3.GetComponent<Renderer>().material = camo1;
        }

        if (shuffle[2] == 2)
        {
            planeta3.GetComponent<Renderer>().material = camo2;
        }

        if (shuffle[2] == 3)
        {
            planeta3.GetComponent<Renderer>().material = camo3;
        }

        if (shuffle[2] == 4)
        {
            planeta3.GetComponent<Renderer>().material = camo4;
        }
        if (shuffle[2] == 5)
        {
            planeta3.GetComponent<Renderer>().material = camo5;
        }


        if(shuffle[3] == 1)
        {
            planeta4.GetComponent<Renderer>().material = camo1;
        }

        if (shuffle[3] == 2)
        {
            planeta4.GetComponent<Renderer>().material = camo2;
        }

        if (shuffle[3] == 3)
        {
            planeta4.GetComponent<Renderer>().material = camo3;
        }

        if (shuffle[3] == 4)
        {
            planeta4.GetComponent<Renderer>().material = camo4;
        }
        if (shuffle[3] == 5)
        {
            planeta4.GetComponent<Renderer>().material = camo5;
        }


        if(shuffle[4] == 1)
        {
            planeta5.GetComponent<Renderer>().material = camo1;
        }

        if (shuffle[4] == 2)
        {
            planeta5.GetComponent<Renderer>().material = camo2;
        }

        if (shuffle[4] == 3)
        {
            planeta5.GetComponent<Renderer>().material = camo3;
        }

        if (shuffle[4] == 4)
        {
            planeta5.GetComponent<Renderer>().material = camo4;
        }
        if (shuffle[4] == 5)
        {
            planeta5.GetComponent<Renderer>().material = camo5;
        }

        var shuffle1 = pilaEnteros1.OrderBy(x => System.Guid.NewGuid()).ToList();

        if (shuffle1[0] == 1)
        {
            Surprise.GetComponent<Renderer>().material = SurpriseTex;
        }

        if (shuffle[0] == 2)
        {
            Surprise.GetComponent<Renderer>().material = RewardTex;
        }
        if (shuffle[0] == 3)
        {
            Surprise.GetComponent<Renderer>().material = SurpriseTex;
        }
        if (shuffle[0] == 4)
        {
            Surprise.GetComponent<Renderer>().material = RewardTex;
        }
        if (shuffle[0] == 5)
        {
            Surprise.GetComponent<Renderer>().material = SurpriseTex;
        }
        if (shuffle[1] == 1)
        {
            Surprise2.GetComponent<Renderer>().material = SurpriseTex;
        }

        if (shuffle[1] == 2)
        {
            Surprise2.GetComponent<Renderer>().material = RewardTex;
        }
        if (shuffle[1] == 3)
        {
            Surprise2.GetComponent<Renderer>().material = SurpriseTex;
        }
        if (shuffle[1] == 4)
        {
            Surprise2.GetComponent<Renderer>().material = RewardTex;
        }
        if (shuffle[1] == 5)
        {
            Surprise2.GetComponent<Renderer>().material = SurpriseTex;
        }

        if (shuffle[2] == 1)
        {
            Surprise3.GetComponent<Renderer>().material = RewardTex;
        }

        if (shuffle[2] == 2)
        {
            Surprise3.GetComponent<Renderer>().material = SurpriseTex;
        }
        if (shuffle[2] == 3)
        {
            Surprise3.GetComponent<Renderer>().material = RewardTex;
        }
        if (shuffle[2] == 2)
        {
            Surprise3.GetComponent<Renderer>().material = SurpriseTex;
        }
        if (shuffle[2] == 2)
        {
            Surprise3.GetComponent<Renderer>().material = SurpriseTex;
        }
        if (shuffle[3] == 1)
        {
            Surprise4.GetComponent<Renderer>().material = SurpriseTex;
        }

        if (shuffle[3] == 2)
        {
            Surprise4.GetComponent<Renderer>().material = RewardTex;
        }

       
        if (shuffle[4] == 1)
        {
            Surprise5.GetComponent<Renderer>().material = RewardTex;
        }

        if (shuffle[4] == 2)
        {
            Surprise5.GetComponent<Renderer>().material = SurpriseTex;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
