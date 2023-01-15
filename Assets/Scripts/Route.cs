using System.Collections;
using System.Collections.Generic;
using Dreamteck.Splines;
using UnityEngine;

public class Route : MonoBehaviour
{
    private SplineFollower _follower;
    // Start is called before the first frame update
    void Start()
    {
        _follower = GetComponent<SplineFollower>();
    }

    // Update is called once per frame

}
