using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public SteamVR_Action_Vector2 input;
    public float speed = 1;
    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * new Vector3(input.axis.x, 0, input.axis.y);
    }
}
