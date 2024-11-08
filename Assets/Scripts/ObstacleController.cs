using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ObstacleController : MonoBehaviour
{
    private float timer = 0;
    private float screenHalfHeight;
    private float screenHalfWidth;
    
    public Obstacle obstacle;
    public float spawnRate;

    private void Start()
    {
        screenHalfHeight = Camera.main.orthographicSize;
        screenHalfWidth = Camera.main.aspect * screenHalfHeight;
    }
    public void Update()
    {
        timer += Time.deltaTime;

        if (!(timer >= spawnRate))
            return;
        
        Spawn();
        timer = 0;
    }

    private void Spawn()
    {
        Instantiate(obstacle);
    }
}
