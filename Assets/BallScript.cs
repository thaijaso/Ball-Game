using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody myRigidBody;
    public float myGravity = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myRigidBody.AddForce(Vector3.down * myGravity);
    }
}
