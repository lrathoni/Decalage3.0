using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0f,0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, speed*Mathf.Sin(Time.time), 0f);
    }
}
