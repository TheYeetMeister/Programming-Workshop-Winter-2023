using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    public float MinX;
    public float MaxX;
    public GameObject BulletPrefab;

    void Update()
    {
        HandleMovement();
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
        
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(BulletPrefab, new Vector3(transform.postion.x, transform.postion.y + 1, transoform.position.z), Quaternion.identity, null);
        }
    }
}
