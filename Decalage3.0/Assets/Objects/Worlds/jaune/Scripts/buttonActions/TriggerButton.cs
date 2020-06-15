using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{

    // Start is called before the first frame update
    public Transform World;
    float firstPos;
    private bool TriggerActive = false;
    void Start()
    {
        TriggerActive = false;
        firstPos = transform.position.y;
    }

    void Update() {
        if (TriggerActive) {
            if ( this.transform.position.y > (firstPos-0.2f) ) {
                this.transform.position -= new Vector3(0f, 0.01f * Time.deltaTime, 0f);
            }
        }
        else {
            if (this.transform.position.y < firstPos) {
                this.transform.position += new Vector3(0f, 0.01f * Time.deltaTime, 0f);
            }
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col) {
        World.GetComponent<RotateWorld>().enabled = true;
        TriggerActive = true;
    }

    
    void OnTriggerExit(Collider col) {
        TriggerActive = false;
    }
}
