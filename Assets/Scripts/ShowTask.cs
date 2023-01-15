using System.Collections;
using System.Collections.Generic;
using Dreamteck.Splines;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

public class ShowTask: MonoBehaviour
{
    //public InputActionReference showReference = null;
    public GameObject plane;
    public GameObject plane_2;
    //public SplineFollower follwer;
    // Start is called before the first frame update
    private void Awake()
    {
        //showReference.action.started += Show;
    }
    private void OnDestroy()
    {
        //showReference.action.started -= Show;
    }

    private void Show(InputAction.CallbackContext context)
    {
        if(plane.activeInHierarchy)
        {
            plane.SetActive(false);
            plane_2.SetActive(false);
        }

        else
        {
            plane.SetActive(true);
            
        }
    }
    private void Start()
    {
        plane.SetActive(false);
        plane_2.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(plane.activeInHierarchy)
            {
                plane.SetActive(false);
            }
            else
            {
                plane.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (plane_2.activeInHierarchy)
            {
                plane_2.SetActive(false);
            }
            else
            {
                plane_2.SetActive(true);
            }
        }



    }



}
