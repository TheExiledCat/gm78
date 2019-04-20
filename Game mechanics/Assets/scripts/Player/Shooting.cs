using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    public int ammo = 10;
    AudioSource shot;
    
    AudioClip reload;
    Object bullet;
    int reloadTime =-1;
    bool isReloading = false;
    // Start is called before the first frame update
    void Start()
    {
        reload = Resources.Load<AudioClip>("reload");
        shot = GetComponent<AudioSource>();
        bullet = Resources.Load("bullet");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
                Debug.Log("shot");


            if (ammo > 0)
            {
                ammo--;
                Instantiate(bullet, transform.position, transform.rotation);//shoot bullet
                shot.Play();
            }
            else if (ammo == 0)
            {

                reloadTime = 120;//start reload 
                ammo=-1;
                
                Debug.Log("COVER ME IM RELOADING");
                shot.PlayOneShot(reload);
            }
            
            
        }
        if (reloadTime == 0)//check if reloading is done and then reset ammo
            {
                ammo = 10;
            }
            if (reloadTime >= 0)
            {
                reloadTime--;
            }
            
        
    }
    
}
