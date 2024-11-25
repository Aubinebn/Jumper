using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Vector3 initialPosition;
    private float width;
    
    public GameObject camera;
    public float parallaxRatio;

    void Start()
    {
        initialPosition = transform.position;
        width = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {
        float dist = camera.transform.position.x * parallaxRatio;
        float temp = camera.transform.position.x * (1 - parallaxRatio);    
        
        transform.position = new Vector3(initialPosition.x + dist, initialPosition.y, initialPosition.z);
        
        
        if (temp > initialPosition.x + width)
            initialPosition.x += width;
        else if (temp < initialPosition.x - width)
            initialPosition.x -= width;
    }
}
