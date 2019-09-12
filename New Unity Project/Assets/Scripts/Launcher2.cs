using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher2 : MonoBehaviour
{



    public Transform LaunchPoint;
    public GameObject UnitPrefab;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            Launch();
        }
    }



    void Launch()
    {
        Instantiate(UnitPrefab, LaunchPoint.position, LaunchPoint.rotation);
    }
}
