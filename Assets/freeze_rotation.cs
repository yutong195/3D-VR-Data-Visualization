using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeze_rotation : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {

    }
        

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z);
    }
}
