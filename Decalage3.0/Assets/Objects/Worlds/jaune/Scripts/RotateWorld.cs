using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWorld : MonoBehaviour
{
    float rot = 90f;
    float delta =0f;
    int rotAxis;
    // Start is called before the first frame update
    void Start()
    {
        rot = 90f;
        delta = Random.Range(0f,3f) * Time.deltaTime;
        rotAxis = Random.Range(0,2);
        this.GetComponent<RotateWorld>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( rot > 0f) {
            if( rotAxis == 0 )
                transform.Rotate(delta,0f,0f );
            else
                transform.Rotate(0f,0f,delta );
            rot -= delta;
        }
        else {
            rot = 90f;
            delta = Random.Range(0f,3f) * Time.deltaTime;
            rotAxis = Random.Range(0,2);
            this.GetComponent<RotateWorld>().enabled = false;
        }
    }
}
