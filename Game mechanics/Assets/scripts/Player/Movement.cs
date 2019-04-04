using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    MouseToWorld mtw;
    
    Rigidbody rb;
    
    float fMoveInX;
    float fMoveInY;
    float ms = 10;
    float fLookAngle;
    
    bool bIsSuper = false;
    bool bIsAlive = false;
    int ammo = 5;
    Vector2 v2MousePos;
    // Start is called before the first frame update
    void Start()
    {
        
        mtw = GetComponent<MouseToWorld>();
        bIsAlive = true;//set player to be alive
        rb = GetComponent<Rigidbody>();//get ridgidbody into rb var
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        


        fMoveInX = Input.GetAxis("Horizontal");//Input
        fMoveInY = Input.GetAxis("Vertical");//Input
        rb.velocity = new Vector3(fMoveInX * ms, 0, fMoveInY*ms);//movement oneliner
        Debug.Log(v2MousePos);
        
        
    }
    private void FixedUpdate()
    {
        float dist = Vector3.Distance(transform.position, mtw.point);
        if(dist >= 1f)
        {
            transform.LookAt(mtw.point);
        }
        transform.rotation = new Quaternion(0, transform.rotation.y, 0, transform.rotation.w);
        
        
    }
}
