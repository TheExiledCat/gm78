using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    int wave = 1;
    GameObject creeper;
    
    public List<GameObject> creepers = new List<GameObject>();
    void Spawner()
    {
        for(int i = 0; i < wave; i++)
        {
            var creep =Instantiate(creeper, new Vector3(transform.position.x + i * 0.1f, GameObject.Find("Player").transform.position.y, transform.position.z), Quaternion.identity, gameObject.transform);
            creepers.Add(creep);
        }
    }
    private void Start()
    {
        creeper = Resources.Load<GameObject>("DJRCreeper");
        Spawner();
    }
    private void Update()
    {
        
    }
    private void NextWave()
    {
        wave++;
        Spawner();
    }
}
