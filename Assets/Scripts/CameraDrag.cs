using UnityEngine;
using System.Collections;

public class CameraDrag : MonoBehaviour
{
    private Vector3 origin;
    private Vector3 difference;
    private Vector3 cameraPosition;
    
    private bool drag = false;
    
    public float dragInertia = 0.1f;
    
    public GameObject camera;
    
    void Start()
    {
    }

    void FixedUpdate()
    {
        cameraPosition = camera.transform.position;
        
        if (Input.GetMouseButton(0))
        {
            difference = camera.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition) - cameraPosition;
            
            if (!drag)
            {
                origin = camera.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);    
                drag = true;
            }

            Vector3 position = camera.transform.position;

            float newX = origin.x - difference.x;
            
            position.x -= (position.x - newX) * dragInertia;
            
            camera.transform.position = position;
        }
        else
        {
            drag = false;
        }
    }
}
