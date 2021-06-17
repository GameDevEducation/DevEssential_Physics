using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveByTorque : MonoBehaviour
{
    [SerializeField] Vector3 TorqueDirection;
    [SerializeField] float TorqueAmount = 2f;
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
        RB.AddTorque(TorqueDirection.normalized * TorqueAmount, Mode);
    }
}
