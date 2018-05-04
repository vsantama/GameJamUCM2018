using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleTargetCam : MonoBehaviour {

    public List<Transform> targets;
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
       // GetTargetsOnScreen();
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
        distance =(targets[0].position.x - targets[1].position.x);
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

    void GetTargetsOnScreen()
    {
        for(int i = 0; i < 3; i++)
        {
            targets[i] = GameObject.FindGameObjectWithTag("Player").transform;
        }
       
    }
    Vector3 GetCenterPoint()
    {
        if(targets.Count == 1)
        {
            return targets[0].position;
        }
        else
        {
            return ((targets[0].position + targets[1].position) / 2);
        }

    }
}
