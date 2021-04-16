using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonscript : MonoBehaviour
{

    public AudioClip click;
    private bool enabled = false;
    public FlyJoystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        joystick.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        enabled = !enabled;
        joystick.enabled = enabled;
        if (!enabled)
        {
            this.transform.position += this.transform.up * 0.1f;
            AudioSource.PlayClipAtPoint(click, transform.position, 1);
        } else
        {
            this.transform.position += this.transform.up * -0.1f;
            AudioSource.PlayClipAtPoint(click, transform.position, 1);
        }
    }
}
