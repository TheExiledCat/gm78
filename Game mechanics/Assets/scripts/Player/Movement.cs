using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{
    MouseToWorld mtw;
    MeshRenderer mr;
    Rigidbody rb;
    public Material normal;
    public Material super;
    float fMoveInX;
    float fMoveInY;
    float ms = 10;
    float fLookAngle;
    public GameObject clock;
    public bool bIsSuper = false;
    bool bIsAlive = false;
    int ammo = 5;
    int supertime;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mtw = GetComponent<MouseToWorld>();
        
        rb = GetComponent<Rigidbody>();//get ridgidbody into rb var
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(supertime);

        if (supertime > 0)
        {
            supertime--;
        }
        Debug.Log(clock.GetComponent<Image>().fillAmount);
        clock.GetComponent<Image>().fillAmount = (float)supertime / 300 ;

        fMoveInX = Input.GetAxis("Horizontal");//Input
        fMoveInY = Input.GetAxis("Vertical");//Input
        rb.velocity = new Vector3(fMoveInX * ms, 0, fMoveInY * ms);//movement oneliner
        if (bIsSuper)
        {
            mr.material = super;
        }
        else
        {
            mr.material = normal;
        }


    }
    private void FixedUpdate()
    {
        float dist = Vector3.Distance(transform.position, mtw.point);
        if (dist >= 1f)
        {
            transform.LookAt(mtw.point);
        }
        transform.rotation = new Quaternion(0, transform.rotation.y, 0, transform.rotation.w);


    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("item"))
        {
            Destroy(other.gameObject);
            bIsSuper = true;
            Invoke("SuperSwap", 5f);
            supertime = 300;
        }
        if (other.CompareTag("enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void SuperSwap()
    {
        bIsSuper = !bIsSuper;
    }
}
