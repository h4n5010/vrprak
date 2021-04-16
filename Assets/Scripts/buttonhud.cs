using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonhud : MonoBehaviour
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
            this.transform.position += new Vector3(0, 0.1f, 0);
            hud.SetActive(false);
            AudioSource.PlayClipAtPoint(click, transform.position, 1);
        }
        else
        {
            this.transform.position += new Vector3(0, -0.1f, 0);
            hud.SetActive(true);
            AudioSource.PlayClipAtPoint(click, transform.position, 1);
        }
    }
}
