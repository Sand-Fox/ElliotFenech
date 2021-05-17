using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 targetPosition;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;


    void Awake()
    {
        targetPosition = transform.position;
    }


    public Vector3 IsoToXY(Vector3 v)
    {
        return new Vector3(0.5f * v.x - v.y, 0.5f * v.x + v.y, 0);
    }

    public Vector3 XYToIso(Vector3 v)
    {
        return new Vector3(v.x + v.y, 0.5f * (v.y - v.x), 0);
    }

    void MovePlayer()
    {
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }

    void MoveRight()
    {
        targetPosition = XYToIso(IsoToXY(transform.position) + new Vector3(0.16f, 0, 0));
    }

    void MoveLeft()
    {
        targetPosition = XYToIso(IsoToXY(transform.position) - new Vector3(0.16f, 0, 0));
    }

    void MoveUp()
    {
        targetPosition = XYToIso(IsoToXY(transform.position) + new Vector3(0, 0.16f, 0));
    }

    void MoveDown()
    {
        targetPosition = XYToIso(IsoToXY(transform.position) - new Vector3(0, 0.16f, 0));
    }

    
    void Update()
    {
        MovePlayer();

    }

}

