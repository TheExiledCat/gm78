using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBirds : MonoBehaviour
{


    int birdcount = 5;
    private void Start()
    {
        for (int i = 0; i < birdcount; i++)
        {
            Instantiate(Resources.Load("bird"), new Vector3(Random.Range(-30, 30), 0, Random.Range(-30, 30)), new Quaternion(0,Random.Range(-180,180),0,Quaternion.identity.w));
        }
    }
    
}
