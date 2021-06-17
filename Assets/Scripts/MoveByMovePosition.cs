using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveByMovePosition : MonoBehaviour
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

        // calculate new position
        Vector3 newPosition = transform.position + movementInput * MoveSpeed * Time.deltaTime;

        // move to new position using physics system
        RB.MovePosition(newPosition);
    }
}
