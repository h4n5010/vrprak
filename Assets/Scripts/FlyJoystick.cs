using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyJoystick : MonoBehaviour
{
    public float speed;
    public float speedAmplifier;
    public float roationSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float inputPitch = Input.GetAxis("Pitch");
        float inputRoll = Input.GetAxis("Roll");
        float inputYawn = Input.GetAxis("Yawn");
        float inputThrottle = Input.GetAxis("Throttle");
        Vector3 rotation = new Vector3(inputPitch, inputYawn, inputRoll);
        this.transform.Rotate(rotation * Time.deltaTime * roationSpeed);
        speed = inputThrottle * speedAmplifier;
        this.transform.Translate(0, 0, speed);
    }
}
