using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleTargetCam : MonoBehaviour {

    public List<Transform> targets;
    private Camera mainCam;
    public Vector3 offset = new Vector3(0,0,-10);
    public float distance;
    public float camSize = 5f;
    public float maxZoom = 7f;

    private void Start()
    {  
        mainCam = GetComponent<Camera>();
    }
    private void LateUpdate()
    {
        Move();
        Zoom();
    }

    void Move()
    {
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPos = centerPoint + offset;

        transform.position = newPos;
        Debug.Log(centerPoint);
    }
    void Zoom()
    {
        if(targets.Count > 1)
        {

            distance = (targets[0].transform.position.x - targets[1].transform.position.x);
            if(Mathf.Sign(distance) == -1)
            {
                distance = -distance;
            }
            if(distance > 15)
            {
                mainCam.orthographicSize = Mathf.Lerp(mainCam.orthographicSize, maxZoom, Time.deltaTime);
            }
            if(distance < 15)
            {
                mainCam.orthographicSize = Mathf.Lerp(mainCam.orthographicSize, camSize,  Time.deltaTime);
            }
        }
    }

    void erasePlayerFromCamera(Transform player)
    {
        targets.Remove(player);
    }

    void addTargetToCamera(Transform player)
    {
        targets.Add(player);
    }

    Vector3 GetCenterPoint()
    {
        if(targets.Count == 1)
        {
            return targets[0].transform.position;
        }
        else
        {
            Vector3 centro = ((targets[0].transform.position + targets[1].transform.position) / 2);
            return centro;
        }

    }
}
