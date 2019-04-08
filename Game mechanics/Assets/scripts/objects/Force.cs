using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    float ms = 1;
    float timer = 180;

    // Update is called once per frame
    void Update()
    {
        timer--;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
        
        transform.position += transform.forward * ms;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            collision.gameObject.GetComponent<Death>().hp -= 20;
            Destroy(gameObject);
            Debug.Log("hit");
        }
    }

}
