using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleHP : MonoBehaviour
{
    public float castleHP = 10;
    public float castle2HP = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
