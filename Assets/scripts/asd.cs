﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class asd : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
   void FixedUpdate()
    {
        transform.Translate(direction.normalized*speed);
    }
}