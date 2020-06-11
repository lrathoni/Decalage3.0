using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// *******************************************
// Buildings will move up the y-axis (depends on the random number)
// *******************************************

public class BuildingsMove : MonoBehaviour
{   
    public float random_number;
    public float i;

    private void Start() 
    {
        // Invokes MoveBuilding() 5 seconds after the start, every 10 seconds
        InvokeRepeating("GenerateRandomNumber", 5.0f, 10f);
        i = 0f;
    }
    void GenerateRandomNumber()
    {
        random_number = Random.Range(0, 200);
    }

    void Update() 
    {
        i += 0.001f;
        transform.position = new Vector3(transform.position.x, transform.position.y + i, transform.position.z);

        if (i > random_number || transform.position.y > 220f)            
        {
            transform.position = new Vector3(transform.position.x, -20f, transform.position.z);
            i = 0f;
        }
    }
}
