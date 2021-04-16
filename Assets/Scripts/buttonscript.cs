using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonscript : MonoBehaviour
{

    public AudioClip click;
    public GameObject hud;
    private bool enabled = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        enabled = !enabled;
        if (!enabled)
        {
            this.transform.position += new Vector3(0.1f, 0, 0);
            hud.SetActive(false);
        } else
        {
            this.transform.position += new Vector3(-0.1f, 0, 0);
            hud.SetActive(true);
        }
    }
}
