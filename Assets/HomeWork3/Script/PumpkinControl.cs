using System;
using UnityEngine;
using System.Collections;


public class PumpkinControl : MonoBehaviour
{


    private GameObject player;
    private Vector3 distance;
    private Transform button;
    public GameObject RotatorPumpkin;
    public Light PumpkinShine;

    private Color switchButtomColor;
    private bool rotationSwich;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
        button = transform;
        switchButtomColor = GetComponent<Renderer>().material.color;
        rotationSwich = RotatorPumpkin.GetComponent<RotationPump>().enabled;
        StartCoroutine(SwitchMove());
    }

    IEnumerator SwitchMove()
    {
        for (;;)
        {
            distance = player.transform.position - button.position;
            if (Input.GetButton("Use") && distance.magnitude < 3f)
            {
                rotationSwich = !rotationSwich;
                RotatorPumpkin.GetComponent<RotationPump>().enabled = rotationSwich;
                if (rotationSwich == false)
                    PumpkinShine.GetComponent<Light>().intensity = 1f;
                switchButtomColor = switchButtomColor == Color.red ? Color.green : Color.red;
              button.GetComponent<Renderer>().material.color = switchButtomColor;
                button.localPosition = new Vector3(button.localPosition.x*-1f, button.localPosition.y,
                    button.localPosition.z);
                yield return new WaitForSeconds(0.5f);
            }
            yield return new WaitForFixedUpdate();
        }
    }

}
