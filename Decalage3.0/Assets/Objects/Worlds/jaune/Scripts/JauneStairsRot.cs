using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JauneStairsRot : MonoBehaviour
{
    public float speed;
 
	void Start () {
	}

	void Update () {
		//transform.Rotate(new Vector3(0f , Time.deltaTime * speed, 0f), Space.World);
        transform.Rotate(0f , 0f, Time.deltaTime * speed);
	}
}
