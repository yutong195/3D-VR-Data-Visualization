using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(car.transform.position.x, car.transform.position.y+1, car.transform.position.z);
        this.transform.eulerAngles = new Vector3(car.transform.eulerAngles.x, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(car.transform.position.x + 3, car.transform.position.y + 1, car.transform.position.z);
        this.transform.eulerAngles = new Vector3(car.transform.eulerAngles.x, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
    }
}
