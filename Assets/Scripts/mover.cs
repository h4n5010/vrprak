using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public Vector3 Velocity = new Vector3(1, 0, 0);

    [Range(0, 5)]
    public float RotateSpeed = 1f;
    [Range(0, 5)]
    public float RotateRadiusX = 1f;
    [Range(0, 5)]
    public float RotateRadiusY = 1f;

    public bool Clockwise = true;

    private Vector3 _centre;
    private float _angle;

    private void Start()
    {
        _centre = transform.position;
    }

    private void Update()
    {
        _centre += Velocity * Time.deltaTime;

        _angle += (Clockwise ? RotateSpeed : -RotateSpeed) * Time.deltaTime;

        var x = Mathf.Sin(_angle) * RotateRadiusX;
        var y = Mathf.Cos(_angle) * RotateRadiusY;

        //transform.position = _centre + new Vector3(x, y, 0);
    }

    
}
