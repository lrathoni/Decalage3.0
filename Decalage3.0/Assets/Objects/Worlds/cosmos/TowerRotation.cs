using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// **************************************************
// Make the tower rotate around the z-axis
// **************************************************
public class TowerRotation : MonoBehaviour
{
    public float tiltAroundZ;
    void Update()
    {     
        transform.Rotate (0, 0, tiltAroundZ);
    }
}
