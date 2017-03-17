using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Script_2 : MonoBehaviour {

    // Use this for initialization
    void Start() { }
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    private bool grounded = false;

    Rigidbody GetComponent<Rigidbody>;
    void FixedUpdate()
    {
        if (grounded)
        { }
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;


        if (Input.GetButton("Jump"))
        {
moveDirection.y = jumpSpeed;
        }
    }
}
// Update is called once per frame
void Update()
{
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");
    Vector3 direction = new Vector3(horizontal, 0f, vertical);
    Rigidbody.addforce(direction * speed);
}