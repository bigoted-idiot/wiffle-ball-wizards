using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSwing : MonoBehaviour
{
    public Transform hitBall;



    public float swingDuration = 1f;
    public float swingSpeed = 0.5f;

    private float swingTimer = 0f;
    private bool swinging = false;
    private Vector3 startRot;
    public Animator anim;
    public GameObject baseballPrefab;

    // Start is called before the first frame update
    void Start()
    {
        startRot = transform.eulerAngles;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    
        if (Input.GetMouseButtonDown(0))
        {
            swinging = true;
           // anim.SetBool("isSwinging", true);
            anim.SetTrigger("Swing");

        }

        if (swinging)
        {
            swingTimer += Time.deltaTime;


            //if (swingTimer < (swingDuration / 2))
            //{
            //    //transform.eulerAngles = Vector3.Slerp(startRot, end.eulerAngles, swingSpeed);
            //    transform.Rotate(end.eulerAngles, Space.World);
            //}

            //if (swingTimer > (swingDuration / 2))
            //{
            //    //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, startRot, swingSpeed);
            //    transform.Rotate(start.eulerAngles, Space.World);
            //}

            if (swingTimer > swingDuration)
            {
                swingTimer = 0f;
                swinging = false;
                //anim.SetBool("isSwinging", false);

            }
        }
    }

}


