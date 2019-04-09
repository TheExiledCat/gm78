using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    GameObject player;
    
    [HideInInspector]
    public int hp;
    // Start is called before the first frame update
    void Start()
    {
        
        player = Resources.Load<GameObject>("Player");
        hp =  100;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            
            Instantiate(Resources.Load("fire"), transform.position+Vector3.up, Quaternion.identity);
            GameObject source= Instantiate(new GameObject(), transform.position, Quaternion.identity);
            source.AddComponent<AudioSource>();
            source.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("explosion"));
            source.AddComponent<DestroySelf>();
            Destroy(gameObject);
        }
    }
}
