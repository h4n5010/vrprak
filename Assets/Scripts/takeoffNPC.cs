using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeoffNPC : MonoBehaviour
{
    private int counter;
    private bool starting = false;
    private bool rotate = true;
    private bool flying = false;
    public GameObject heli;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (counter > 100)
        {
            starting = true;
        }
        if (starting && !flying)
        {
            heli.transform.Translate(0, 0.1f, 0);
            
            if (heli.transform.rotation.y > -0.8 && rotate) {
                heli.transform.Rotate(0, -0.5f, 0);
                Debug.Log(heli.transform.rotation.y);
            } else
            {
                rotate = false;
            }
           
            if (heli.transform.position.y > 90f)
            {
                starting = false;
                flying = true;
                heli.transform.Rotate(0, 0, 0);
            }
        }
        if (flying)
        {
            heli.transform.Translate(0, 0, 0.1f);
        }
        counter++;
    }
}
