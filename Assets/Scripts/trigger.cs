using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject vfx;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("rocket"))
        {
            GameObject explosion = Instantiate(vfx, this.gameObject.transform.position, Quaternion.identity);
            this.gameObject.SetActive(false);
            Destroy(explosion, 2f);
        }
           
    }
}
