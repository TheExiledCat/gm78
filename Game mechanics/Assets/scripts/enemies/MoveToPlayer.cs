using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    GameObject player;
    float ms = 7;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (!player.GetComponent<Movement>().bIsSuper)
        {
            transform.LookAt(player.transform.position);

        }
        else
        {
            transform.LookAt(2 * transform.position - player.transform.position);

        }
        
        rb.position += transform.forward * ms*Time.deltaTime;
    }
}
