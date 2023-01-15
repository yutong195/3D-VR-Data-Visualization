using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using Dreamteck.Splines;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarStop : MonoBehaviour
{
    public SplineFollower spline;
    public GameObject plane;
    public Camera cam;
    //public InputActionReference stopReference = null;
    // Start is called before the first frame update
    void Start()
    {
        spline = FindObjectOfType<SplineFollower>();
        spline.followSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(spline.followSpeed == 0)
            {
                spline.followSpeed = 10;
            }

            else
            {
                spline.followSpeed = 0;
            }
        }

        if(Input.GetMouseButtonUp(1))
        {
            if(spline.followSpeed >= 0)
            {
                spline.followSpeed = -10f;
                cam.transform.eulerAngles = new Vector3(0, -cam.transform.eulerAngles.y, 0);
                
            }

            else
            {
                spline.followSpeed = 10f;
                cam.transform.eulerAngles = new Vector3(0, 0, 0);

            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            spline.followSpeed = 10f;
            plane.SetActive(false);
        }
    }


}
