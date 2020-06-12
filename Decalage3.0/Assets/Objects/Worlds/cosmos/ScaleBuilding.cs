using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// **************************************************
// Scale building randomly and make it go up and down
// **************************************************
public class ScaleBuilding : MonoBehaviour
{   
    public float random_number;
    private float i, y_variation, y_max_variation, angle;
    private void Start() 
    {
        // Invokes GenerateRandomNumber() 2 seconds after the start, every 10 seconds
        InvokeRepeating("GenerateRandomNumber", 2.0f, 10f);
        i = 0.8f;
        y_variation = 0f;
        y_max_variation = 7f;
        angle = 0f;
    }   
    void GenerateRandomNumber()
    {
        random_number = Random.Range(2f, 5f);
    }
    void Update()
    {
        i += 0.002f;
        transform.localScale = new Vector3(i, i, i);

        if (i > random_number)
            i = 0.8f;

        // Vary y position
        angle += Mathf.PI * Time.deltaTime;
        y_variation = y_max_variation * Mathf.Sin(angle/3f);
        transform.position = new Vector3(transform.position.x, transform.position.y + y_variation, transform.position.z);
    }
}
