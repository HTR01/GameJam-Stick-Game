using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldown : MonoBehaviour
{
    public float cooldownTime = 2;
    float nextFireTime = 0;
    public float cooldownTime2 = 2;
    float nextFireTime2 = 0;
    public GameObject stickUnit;
    public GameObject stickUnit2;

    public Transform LaunchPoint;

    public Transform LaunchPoint2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                print("Spawned unit. Cooldown started.");
                nextFireTime = Time.time + cooldownTime;
                Instantiate(stickUnit, LaunchPoint.position, LaunchPoint.rotation);
            }
        }


        if (Time.time > nextFireTime2)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                print("Spawned unit. Cooldown started.");
                nextFireTime2 = Time.time + cooldownTime2;
                Instantiate(stickUnit2, LaunchPoint2.position, LaunchPoint2.rotation);
            }
        }
    }
}
