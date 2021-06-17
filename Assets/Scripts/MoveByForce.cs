using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveByForce : MonoBehaviour
{
    [SerializeField] Vector3 ForceDirection;
    [SerializeField] float ForceStrength = 10f;
    [SerializeField] ForceMode Mode = ForceMode.Acceleration;

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
        // tell the rigid body to add force
        RB.AddForce(ForceDirection.normalized * ForceStrength, Mode);
    }

    void OnTriggerEnter(Collider other)
    {
        // if we've reached the ceiling - zero the force
        if (other.CompareTag("Ceiling"))
        {
            ForceStrength = 0f;
        }
    }

    void OnTriggerStay(Collider other)
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        
    }    
}
