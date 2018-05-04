using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleTargetCam : MonoBehaviour {

    //public List<Transform> targets;
    public GameObject[] targets;
    private Camera mainCam;
    public Vector3 offset = new Vector3(0,0,-10);
    public float distance;
    public float camSize = 5f;
    public float maxZoom = 10f;

    private void Start()
    {  
        mainCam = GetComponent<Camera>();
    }
    private void LateUpdate()
    {
        GetTargetsOnScreen();
        Move();
        Zoom();
    }

    void Move()
    {
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPos = centerPoint + offset;

        transform.position = newPos;
    }
    void Zoom()
    {
        if(targets.Length > 1)
        {

            distance = (targets[0].transform.position.x - targets[1].transform.position.x);
            if(Mathf.Sign(distance) == -1)
            {
                distance = -distance;
            }
            if(distance > 20)
            {
                mainCam.orthographicSize = Mathf.Lerp(mainCam.orthographicSize, maxZoom, Time.deltaTime);
            }
            if(distance < 20)
            {
                mainCam.orthographicSize = Mathf.Lerp(mainCam.orthographicSize, camSize,  Time.deltaTime);
            }
        }
    }

    void GetTargetsOnScreen()
    {
            targets = GameObject.FindGameObjectsWithTag("Player");
    }
    Vector3 GetCenterPoint()
    {
        if(targets.Length == 1)
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
