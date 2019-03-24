using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBall : MonoBehaviour
{
    public GameObject baseballPrefab;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider bat)
    {
        Debug.Log("entered trigger");

        if (bat == CompareTag("Bat"))

            Debug.Log("BAT");
        {
            var heading = bat.transform.position - transform.position;
            var distance = heading.magnitude;
            var direction = heading / distance; // normalized direction

            GameObject baseball = Instantiate(baseballPrefab, transform.position, transform.rotation);



            //baseball.transform.position = transform.position;
            //Vector3 velo = new Vector3(0f, ballHeight, ballDistance);
            //Vector3 accel = new Vector3(0f, gravityHeight, gravityDistance);


            //rb.velocity = velo;

            //Mathf.MoveTowards(rb.velocity.y, gravityHeight, Time.time * dropRate);
            //Mathf.MoveTowards(rb.velocity.z, gravityDistance, Time.time * slowRate);

            Destroy(gameObject);
        }
    }
}
