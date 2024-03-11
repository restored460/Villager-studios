using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 10;
    private float rotationSpeed = 180;

    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    // Start is called before the first frame update
    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");

        moveVelocity = transform.forward * speed * vInput;
        turnVelocity = transform.up * rotationSpeed * hInput;

        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
        this.transform.position = new Vector3(this.transform.position.x, 2.1407f, this.transform.position.z);
    }

}
