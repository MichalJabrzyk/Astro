using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovements : MonoBehaviour
{
    public float horizontalAxisInput;
    public float verticalAxisInput;

    public float movementSpeed = 1.0f;
    public float rotationSpeed = 1.0f;

    public Rigidbody2D rigidbody2D;
    
    public GameObject destructionFX;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalAxisInput = Input.GetAxis("Horizontal");
        verticalAxisInput = Input.GetAxis("Vertical");
        
        ShipMovement();
        ShipRotation();
    }

    //void Update()
    //{
        
    //}

    void ShipMovement()
    {
        rigidbody2D.velocity = transform.up * Mathf.Clamp01(verticalAxisInput) * movementSpeed;
    }

    void ShipRotation() 
    { 
        float rotation = -horizontalAxisInput * rotationSpeed;
        transform.Rotate(Vector3.forward * rotation);
    }

}