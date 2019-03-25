using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBall : MonoBehaviour
{
    private Rigidbody rb;

    public Transform ballLandingSpot;
    public Transform ballPathPeak;
    public Vector3 ballVelo;
    public float fallRate;
    public Vector3 nextMove;
    public Vector3 endMove;
    public float endMagnitude;
    public float peakMagnitude;

    public float climbTime;
    public float climbCounter;
    private Animator anim;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        //rb.velocity = ballVelo;

        ballLandingSpot = GameObject.FindGameObjectWithTag("Land").transform;
        ballPathPeak = GameObject.FindGameObjectWithTag("Peak").transform;

        climbCounter = climbTime;
        //ballLandingSpot.position *= 10f; //offset for 0.1 scale
        anim = GetComponent<Animator>();
        //have to play animation
        anim.SetInteger("HitArea", 1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //NEED MORE INTRICATE FORM OF MOVEMENT/FALLING

        //use blend tree and animations

        //if some_vector_math is +, hit right, -, hit left, etc.

        //create animations for each type of hit and use SetBool() to pick which animation to trigger

        endMove = ballLandingSpot.position - transform.position;
        nextMove = ballPathPeak.position - transform.position;

        endMagnitude = Vector3.SqrMagnitude(endMove);
        peakMagnitude = Vector3.SqrMagnitude(nextMove);

        Debug.Log("nextMove = " + nextMove + "/nendMove = + " + endMove + "/nEndMagnitude = " + endMagnitude);

        //if (peakMagnitude > 0.2f && climbCounter > 0f) // travel toward peak
        //{
        //    transform.Translate(nextMove * Time.deltaTime);
        //    climbCounter -= Time.deltaTime;
        //    return;
        //}
        //else if (endMagnitude > 0.01f)
        //{
        //    // fall from peak toward landing spot
        //    transform.Translate(endMove * Time.deltaTime);
        //}
        //else
            //return;



    }


}
