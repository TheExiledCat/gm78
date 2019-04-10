using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    AudioSource source;
    public int wave = 1;
    GameObject creeper;
    
    public List<GameObject> creepers = new List<GameObject>();
    
    private void Start()
    {
        creeper = Resources.Load<GameObject>("DJRCreeper");
        source = GetComponent<AudioSource>();
        Spawner();

    }
    void Spawner()
    {
        for(int i = 0; i < wave; i++)
        {
            var creep =Instantiate(creeper, new Vector3(transform.position.x + i * 2f, GameObject.Find("Player").transform.position.y, transform.position.z), Quaternion.identity, gameObject.transform);
            creepers.Add(creep);
        }
    }
    private void Update()
    {
        for(int i = 0; i < creepers.Count; i++)
        {
            if (creepers[i].GetComponent<Death>().hp <= 0)
            {   Instantiate(Resources.Load("fire"), creepers[i].transform.position + Vector3.up, Quaternion.identity);
                Destroy(creepers[i]);
                creepers.Remove(creepers[i]);
                
                
                
                source.PlayOneShot(Resources.Load<AudioClip>("explosion"));
                
            }
        }
        if (creepers.Count == 0)
        {
            
            NextWave();
        }
    }
    private void NextWave()
    {
        wave++;
        Spawner();
    }
}
