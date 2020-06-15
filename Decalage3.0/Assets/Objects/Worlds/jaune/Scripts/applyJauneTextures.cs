using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyJauneTextures : MonoBehaviour
{
    //This var is displayed under the script in the world object 
    public Material[] JauneMat;
    Material[] objectListMat;

    // Start is called before the first frame update
    void Start()
    {
        objectListMat = GetComponent<MeshRenderer>().materials;
        if (JauneMat.Length == 0)
            return;
        
        for(int i=0; i<GetComponent<MeshRenderer>().materials.Length ; i++) {
            objectListMat[i] = JauneMat[Random.Range(0, JauneMat.Length)];
        }
        GetComponent<MeshRenderer>().materials = objectListMat;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
