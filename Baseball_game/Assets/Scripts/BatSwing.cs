using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSwing : MonoBehaviour
{

	public float batSpeed;
    public Vector3 rotation;

    private Transform bat;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
		{
            //Mathf.MoveTowards(bat.transform.rotation.y, yRot, Time.time);
            this.transform.Rotate(rotation, Space.World);
            
		}


    }
}
