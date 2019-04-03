using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject player;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, 8.5f, player.transform.position.z - 5);
    }
}
