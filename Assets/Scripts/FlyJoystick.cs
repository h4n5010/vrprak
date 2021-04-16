using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyJoystick : MonoBehaviour
{
    public float speed;
    public float speedAmplifier;
    public float roationSpeed;
    public Rigidbody projectile;
    public bool enabled = false;
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
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("FIRE");
            if (enabled)
            {
                Vector3 position = transform.position + new Vector3(3.18f, 22.02f, 0.39f);
                Rigidbody bullet = Instantiate(projectile, position, transform.rotation) as Rigidbody;

                bullet.velocity = 500 * transform.forward;
            }
           
        }
    }
}
