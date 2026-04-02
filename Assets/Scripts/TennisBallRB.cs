using UnityEngine;

public class TennisBallRB : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 0.057f;           // Real tennis ball mass (57g)
        rb.linearDamping = 0.1f;             // Air resistance
        rb.angularDamping = 0.05f;
        rb.useGravity = true;
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        // ^ Important � prevents tunneling at high speeds

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
