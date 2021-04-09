using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public Vector3 Velocity = new Vector3(1, 0, 0);

   
    public float RotateSpeed = 0.001f;

    public float RotateRadiusX = 0.001f;

    public float RotateRadiusY = 0.001f;

    public bool Clockwise = true;

    private Vector3 _centre;
    private float _angle;

    private void Start()
    {
        _centre = transform.position;
    }

    private void FixedUpdate()
    {
        _centre += Velocity * Time.deltaTime/10;

        _angle += (Clockwise ? RotateSpeed : -RotateSpeed) * Time.deltaTime/10;

        var x = Mathf.Sin(_angle) * RotateRadiusX;
        var y = Mathf.Cos(_angle) * RotateRadiusY;

        //transform.position = _centre + new Vector3(x, y,0);
    }

    
}
