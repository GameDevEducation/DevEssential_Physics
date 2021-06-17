using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    [SerializeField] float ExplosionForce = 10f;
    [SerializeField] float ExplosionRadius = 20f;
    [SerializeField] float UpwardsModifier = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(gameObject.name + " started collision with " + other.gameObject.name + " at speed of " + other.relativeVelocity.magnitude);

        // if we hit the ground
        if (other.gameObject.CompareTag("Ground"))
        {
            // find all objects that are knockable
            GameObject[] foundObjects = GameObject.FindGameObjectsWithTag("Knockable");

            // calculate force - scale with impact
            float explosionForce = other.relativeVelocity.magnitude * ExplosionForce;

            // apply force to each found object
            foreach(var foundObject in foundObjects)
            {
                foundObject.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, other.GetContact(0).point, ExplosionRadius, UpwardsModifier);
            }
        }
    }

    void OnCollisionStay(Collision other)
    {
        
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log(gameObject.name + " finished collision with " + other.gameObject.name);
    }        
}
