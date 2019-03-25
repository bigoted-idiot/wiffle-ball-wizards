using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBall : MonoBehaviour
{

    //public float ballHeight; //peak height
    //public float ballDistance; //peak distance
    //public float gravityHeight; //height at end of hit
    //public float gravityDistance; //distance from start at end of hit

    //public float dropRate; 
    //public float slowRate; // rate at which the speed of the ball slows down

    private Rigidbody rb;
    public GameObject hitBall;


    public GameObject baseballPrefab;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        hitBall = GameObject.FindWithTag("HitBall");
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("entered trigger");
    //    if (other.CompareTag("Bat"))
    //    {
    //        Debug.Log("tagged as 'Bat'");

    //        var heading = other.transform.position - transform.position;
    //        var distance = heading.magnitude;
    //        var direction = heading / distance; // normalized direction

    //        GameObject baseball = Instantiate(gameObject, transform.position, transform.rotation);

    //        baseball.transform.position = transform.position;
    //        Vector3 velo = new Vector3(0f, ballHeight, ballDistance);
    //        Vector3 accel = new Vector3(0f, gravityHeight, gravityDistance);


    //        rb.velocity = velo;

    //        Mathf.MoveTowards(rb.velocity.y, gravityHeight, Time.time * dropRate);
    //        Mathf.MoveTowards(rb.velocity.z, gravityDistance, Time.time * slowRate);

    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Flying Ball trigger!");

        if (other.CompareTag("Bat"))
        {
            Debug.Log("it's the bat!");
            GameObject baseball = Instantiate(baseballPrefab, hitBall.transform.position, hitBall.transform.rotation);
            Destroy(gameObject);
        }
    }
}

