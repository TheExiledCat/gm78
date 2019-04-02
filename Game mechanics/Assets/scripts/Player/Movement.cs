using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public GameObject goGun;
    float fMoveInX;
    float fMoveInY;
    float ms = 10;
    float fLookAngle;
    bool bHasGun=false;
    bool bIsSuper = false;
    bool bIsAlive = false;
    Vector2 v2MousePos;
    // Start is called before the first frame update
    void Start()
    {
        bIsAlive = true;//set player to be alive
        rb = GetComponent<Rigidbody>();//get ridgidbody into rb var
    }

    // Update is called once per frame
    void Update()
    {
        v2MousePos = Input.mousePosition;
        goGun.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);//rotate gun around player
        fMoveInX = Input.GetAxis("Horizontal");//Input
        fMoveInY = Input.GetAxis("Vertical");//Input
        rb.velocity = new Vector3(fMoveInX * ms, 0, fMoveInY*ms);//movement oneliner
        Debug.Log(v2MousePos);
    }
}
