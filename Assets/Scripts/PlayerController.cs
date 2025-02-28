using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    public float MinX;
    public float MaxX;
    public GameObject BulletPrefab;
    private float deBounce = 0;

    void Update()
    {
        HandleMovement();
        HandleShooting();
    }

    void HandleMovement()
    {
        Vector3 moveDir = Vector3.zero;

        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > MinX)
        {
            moveDir = Vector3.left;
        }

        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < MaxX)
        {
            moveDir = Vector3.right;
        }

        transform.Translate (moveDir * MoveSpeed * Time.deltaTime);
    }

    void HandleShooting()
    {
        if (deBounce <= 0) {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(BulletPrefab, new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z), Quaternion.identity);
                deBounce = 0.5f;
            }
        } else {
            deBounce -= Time.deltaTime;
        }
    }
}
