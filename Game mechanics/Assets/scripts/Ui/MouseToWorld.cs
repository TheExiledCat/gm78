using UnityEngine;

public class MouseToWorld : MonoBehaviour
{
    [HideInInspector]
    
    RaycastHit hit;
    public Vector3 point;
    public LayerMask ground;
    void Start()
    {
        
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray,out hit,ground)){
            Debug.DrawRay(ray.origin, ray.direction*10, Color.red);
            Debug.Log(hit.point);
            point = hit.point;
        }

            
    }
}