using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DisplayFlightData : MonoBehaviour
{
    public Text textSpeed;
    public Text textHeight;
    public GameObject player;
    public float warningHeight;
    public GameObject warnImage;
    private FlyJoystick flyJoystick;
    private bool below_limit;

    // Start is called before the first frame update
    void Start()
    {
        flyJoystick = player.GetComponent<FlyJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        float height = player.transform.position.y - (float)1.57 + 22.28f;
        textHeight.text = "Alt: " + height.ToString("F2") + "m";
        textSpeed.text = "Speed: " + (300 * flyJoystick.speed).ToString("F2") + " km/h";
        if (height < warningHeight)
        {
            if (!below_limit)
            {
                below_limit = true;
                textHeight.color = new Color(255, 0, 0, 1);
                StartBlinking();
            }

        }
        else
        {
            if (below_limit)
            {
                below_limit = false;
                textHeight.color = new Color(0, 0, 0, 1);
                warnImage.SetActive(false);
                StopBlinking();
            }
        }
    }


    IEnumerator Blink()
    {
        while (true)
        {
            switch (warnImage.activeSelf)
            {
                case false:
                    warnImage.SetActive(true);
                    yield return new WaitForSeconds(0.5f);
                    break;
                case true:
                    warnImage.SetActive(false);
                    yield return new WaitForSeconds(0.5f);
                    break;
            }
        }
    }

    void StartBlinking()
    {
        StopAllCoroutines();
        StartCoroutine("Blink");
    }

    void StopBlinking()
    {
        StopAllCoroutines();
    }
}
