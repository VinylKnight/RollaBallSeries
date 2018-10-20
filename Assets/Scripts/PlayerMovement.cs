using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    private Rigidbody PlayerRigidBody;
    [SerializeField]
    private float movementSpeed = 10;
    void start()
    {
        PlayerRigidBody = GetComponent<Rigidbody>();

    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        PlayerRigidBody.AddForce(movement * movementSpeed);


    }
}
