using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float TargetY;
    public float MoveSpeed;
    public float MinX;
    public float MaxX;
    public GameObject player;
    public GameObject bullet;

    bool movingLeft;

    private void Start ()
    {
        // Randomly start moving either left or right
        movingLeft = Random.Range (0.0f, 1.0f) < 0.5f;
    }

    void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            Destroy(player)
        }

        if (collision.gameObject == bullet) 
        {
            Destroy(gameObject)
        }
    }

    private void Update ()
    {
        if (transform.position.y > TargetY)
        {
            // Enemy starts offscreen, so move down until it's in the right place
            transform.position -= Vector3.up * Time.deltaTime * MoveSpeed;
            return;
        }

        // Move
        Vector3 movementDirection = movingLeft ? Vector3.left : Vector3.right;
        transform.position += movementDirection * Time.deltaTime * MoveSpeed;

        // If moved to the left/right all the way, turn around
        if (transform.position.x < MinX || transform.position.x > MaxX)
        {
            movingLeft = !movingLeft;
        }
    }
}
