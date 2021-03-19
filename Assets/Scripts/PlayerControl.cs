using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject scoreboard;
    public float speed;
    public bool keyboard;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        scoreboard.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (keyboard)
        {
       
            rb.AddForce(moveHorizontal * speed, 0, moveVertical * speed, ForceMode.Force);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score++;
            if (score != 11)
            {
                scoreboard.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();

            }
            else
            {
                scoreboard.GetComponent<UnityEngine.UI.Text>().text = "Gewonnen!";

            }
        } else if (other.gameObject.CompareTag("Enemy"))
        {
            scoreboard.GetComponent<UnityEngine.UI.Text>().text = "Veloren!";
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }

    }
}
