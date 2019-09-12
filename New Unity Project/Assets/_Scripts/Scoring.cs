using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public string teamname;
    public HPManager HPMan;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);


        if (teamname == "Blue")
        {
            HPMan.Castle1HP();
        }

        if (teamname == "Red")
        {
            HPMan.Castle2HP();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
