﻿using System.Collections;
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
        Vector2 moveDirection = Vector2(0, 1);
        transform.position += movementDIrection * Time.deltaTime * MoveSpeed;
    }
}
