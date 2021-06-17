using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveByVelocity : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 2f;

    Rigidbody RB;

    // Start is called before the first frame update
    void Start()
    {
        // retrieve the rigid body
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // retrieve the movement input
        Vector3 movementInput = Input.GetAxis("Horizontal") * transform.right +
                                Input.GetAxis("Vertical") * transform.forward;

        // update the velocity
        RB.velocity = movementInput * MoveSpeed;
    }    
}
