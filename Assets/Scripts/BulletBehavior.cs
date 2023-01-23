using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior: MonoBehaviour
{
    public float BulletSpeed;
    public float maxY;
    
    // Update is called once per frame
    void Update()
    {
        //Move
        Vector3 moveDirection = Vector3.up;
        transform.position += moveDirection * Time.deltaTime * BulletSpeed;

        if (transform.position.y > maxY) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyUnit")
        {
            
        }
    }
}
