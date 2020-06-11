using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouette : MonoBehaviour
{
    public float speed;
    public Vector3 path_centre;
    public float path_radius;
    private Rigidbody rb;
    private float x_position, z_position, angle, tiltAroundY;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        x_position = transform.position.x;
        z_position = transform.position.z;
        angle = 0f;
        tiltAroundY = 0f;
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

        
        transform.position = new Vector3(x_position, 27f, z_position);
    }
}
