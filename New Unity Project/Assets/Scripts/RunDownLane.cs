using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunDownLane : MonoBehaviour
{


   // public float speed = 20f;
   // public Rigidbody rb;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
       // rb.velocity = transform.right * speed;
    }


    private void OnTriggerEnter(Collider hitInfo)
    {
        Castle castle = hitInfo.GetComponent<Castle>();
        if (castle != null)
        {
            castle.TakeDamage(damage);
        }
        Destroy(gameObject);
    }


}
