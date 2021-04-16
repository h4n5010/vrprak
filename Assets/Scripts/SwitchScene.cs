using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    public string scene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("CHANGE" + this.transform.rotation.y);
        if (this.transform.rotation.y < -0.02)
        {
           
            SceneManager.LoadScene(scene);
        }
    }
}
