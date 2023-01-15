using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
public class PlayerControllerLine_2 : MonoBehaviour
{
    // Start is called before the first frame update

    public SteamVR_Action_Vector2 input;
    public float speed = 15;
    //private CharacterController characterController;
    // Update is called once per frame
    private void Start()
    {
        //characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        Vector3 direction;
        if (this.gameObject.transform.position.z > -25f)
        {
            direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
            transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
        }
        //Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
        //transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
        //characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up));
        else
        {
            if (input.axis.y < 0)
            {

                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, -25f);
            }
            else
            {
                //this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, -70f);
                direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
                transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
            }


        }
    }
}
