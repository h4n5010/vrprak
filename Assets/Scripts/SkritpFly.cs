using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkritpFly : MonoBehaviour
{

    public int speed;

    public SkritpFly(int speed)
    {
        this.speed = speed;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed * 2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0f, -20f * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed * 2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0f, 20f * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Translate(Vector3.down * speed / 4 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Translate(Vector3.up * speed / 4 * Time.deltaTime);
        }
    }
}
