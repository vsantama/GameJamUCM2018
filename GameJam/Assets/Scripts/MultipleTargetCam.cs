using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleTargetCam : MonoBehaviour {

    public List<Transform> targets;
    private Camera mainCam;
    public Vector3 offset;
    public float camSize = 5f;
    public float distance;


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
    }
    void Zoom()
    {
        distance =(targets[0].position.x - targets[1].position.x);
        if(Mathf.Sign(distance) == -1)
        {
            distance = -distance;
        }
        Debug.Log(distance);
        if(distance > 20)
        {
            mainCam.orthographicSize = Mathf.Lerp(mainCam.orthographicSize, 10, Time.deltaTime);
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
