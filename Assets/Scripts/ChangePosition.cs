using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //player.transform.position = new Vector3(123f, 110f, -66f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
            
        {

            Debug.Log("left contrl");
            if(player.transform.position.y > 80f)
            {
                player.transform.position = new Vector3(123f, 110f, -66f);
            }
            else
            {
                player.transform.position = new Vector3(200f, 62f, -133f);
            }
        }
    }
}
