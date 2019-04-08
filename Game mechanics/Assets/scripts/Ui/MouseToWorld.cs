using UnityEngine;

public class MouseToWorld : MonoBehaviour
{
    [HideInInspector]
    
    RaycastHit hit;
    public Vector3 point;
    public LayerMask ground;
    GameObject cursor;
    void Start()
    {
        cursor = Instantiate(Resources.Load<GameObject>("Cursor"),Vector3.zero,Quaternion.identity);

    }

    private void Update()
    {
       
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray,out hit,ground)){
            Debug.DrawRay(ray.origin, ray.direction*10, Color.red);
            //Debug.Log(hit.point);
            point = hit.point;
        }
        cursor.transform.position = new Vector3(point.x,0,point.z);
        
            
    }
}