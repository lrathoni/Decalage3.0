using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// **************************************************
// Make the mouette fly in a circle 
// **************************************************

public class Mouette : MonoBehaviour
{
    public float speed;
    public Vector3 path_centre;
    public float path_radius;
    public float height;
    private float x_position, z_position, angle, tiltAroundY, y_max_variation, y_variation;
    public void Start()
    {
        x_position = transform.position.x;
        z_position = transform.position.z;
        angle = 0f;
        tiltAroundY = 0f;
        y_variation = 0f;
        y_max_variation = 8f;
    }
    void Update()
    {
        // New positions
        x_position = path_centre.x + Mathf.Cos(angle) * path_radius; 
        z_position = path_centre.z + Mathf.Sin(angle) * path_radius; 
        // New angle
        angle += Mathf.PI/64 * Time.deltaTime * speed;
        // Tilt the mouette
        tiltAroundY += 0.00002f;
        transform.eulerAngles = new Vector3(
            transform.eulerAngles.x,
            transform.eulerAngles.y + tiltAroundY,
            transform.eulerAngles.z
            );
        // Vary y position
        y_variation = y_max_variation * Mathf.Sin(angle*10);

        transform.position = new Vector3(x_position, height + y_variation, z_position);
    }
}
