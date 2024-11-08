using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float moveSpeed = 2;

    public void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.left);
    }
}
