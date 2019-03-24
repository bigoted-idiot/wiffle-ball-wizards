using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBall : MonoBehaviour
{
    private Rigidbody rb;

    public Transform ballLandingSpot;
    public Vector3 ballVelo;
    public float fallRate;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = ballVelo;
        ballLandingSpot = GameObject.FindGameObjectWithTag("Land").transform;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //NEED MORE INTRICATE FORM OF MOVEMENT/FALLING

        //use blend tree and animations

        //if some_vector_math is +, hit right, -, hit left, etc.

        //create animations for each type of hit and use SetBool() to pick which animation to trigger

        rb.MovePosition(ballLandingSpot.position);

    }


}
