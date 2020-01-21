﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    Transform RoomTransform;
    Vector3 RoomMeshSize;
    Transform PlayerTransform;

    public float timeBetweenEventChangeInSeconds = 15f;
    private void Start()
    {
        RoomTransform = GameObject.FindGameObjectWithTag("MainRoom").transform;
        RoomMeshSize = GameObject.FindGameObjectWithTag("MainRoom").GetComponent<MeshFilter>().sharedMesh.bounds.size;
        Debug.Log("Room size : " + RoomMeshSize);
        PlayerTransform = GameObject.FindGameObjectWithTag("MainCharacter").transform;
    }
    public int getEventID()
    {
        Vector3 roomSize = Matrix4x4.Scale(RoomTransform.parent.localScale) * Matrix4x4.Scale(RoomTransform.localScale) * RoomMeshSize;
        float distX = (RoomTransform.position.x - PlayerTransform.position.x) / RoomMeshSize.z;
        float distZ = (RoomTransform.position.z - PlayerTransform.position.z) / RoomMeshSize.z;
        int quadrantID =  (distX < 0 ? 0 : 1)
                       +2*(distZ < 0 ? 0 : 1);
        int timeID = Mathf.RoundToInt(Time.time / timeBetweenEventChangeInSeconds);
        return (quadrantID + timeID)% 4;
    }
}
