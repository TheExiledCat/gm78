using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAway : MonoBehaviour
{
    int destroytimer = -1;
    float ms = 6;
    GameObject player;
    bool isFlying = false;
    void Start()
    {
        player = GameObject.Find("Player");
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.LookAt(2*transform.position-player.transform.position);
            isFlying = true;
            destroytimer = 60;
        }
        

    }
    private void Update()
    {
        if (destroytimer > 0) { destroytimer--; }
        else if (destroytimer == 0) { Destroy(gameObject); }
        if (isFlying)
        {
            transform.position += transform.forward * ms*Time.deltaTime;
            transform.position += transform.up * ms * Time.deltaTime;
        }
    }




}
