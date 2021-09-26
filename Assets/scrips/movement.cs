using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class movement : MonoBehaviour
{
   
public float speed = 8.0f;
public float speedMultiplier = 1.0f;
public Vector2 initialDirection;
public LayerMask obstacleLayer;
public new Rigidbody2D rigidbody{ get; private set;}
public Vector2 direction {get; private set;}

private void Awake()
{
this.rigidbody = GetComponent<Rigidbody2D>();
}
}
    