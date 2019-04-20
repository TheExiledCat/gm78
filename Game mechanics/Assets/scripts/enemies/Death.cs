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

   

}
