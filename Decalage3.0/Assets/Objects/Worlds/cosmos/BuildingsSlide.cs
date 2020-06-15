using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// **************************************************
// Make buildings slide on the x/z-axis
// **************************************************
public class BuildingsSlide : MonoBehaviour
{
    public float speed, speed2;
    private float angle, angle2;
    private float x_variation, z_variation;

    void Update()
    {
        angle += Mathf.PI/64 * Time.deltaTime * speed;
        angle2 += Mathf.PI/64 * Time.deltaTime * speed2;

        x_variation = Mathf.Sin(angle);
        z_variation = Mathf.Sin(angle2);
        transform.position = new Vector3(transform.position.x+x_variation, transform.position.y, transform.position.z+z_variation);
    }
}
