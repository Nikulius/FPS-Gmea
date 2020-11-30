using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    private Rigidbody rb ;
    [SerializeField] float sprintMultiplier = 1.5f;
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    public float speed;

    void Update() 
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 movement = transform.right * x + transform.forward * z;

        float actualSpeed = speed;
        if (Input.GetKey(KeyCode.LeftShift)) {
            actualSpeed *= sprintMultiplier;
        }
        
        rb.MovePosition(transform.position + movement.normalized * actualSpeed * Time.deltaTime);
    }
}
