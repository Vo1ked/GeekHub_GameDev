using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PortalActivate : MonoBehaviour {
    public Transform player;
    public Transform portal;
    private Vector3 playerPos;
    private float colorInit = 0.2f;
    private float colorTransfer = 0.004f;
    void Start () {
        portal = transform;
        playerPos = portal.position - player.position;
        GetComponent<Renderer>().material.color = new Color(colorInit, colorInit + colorTransfer , colorInit);
    }
    void FixedUpdate() {
        Vector3 newDistance = portal.position - player.position;
        float curentG = GetComponent<Renderer>().material.color.g;
            if (playerPos.magnitude != newDistance.magnitude) {
                if (playerPos.magnitude < newDistance.magnitude && curentG > colorInit) {
                    GetComponent<Renderer>().material.color = new Color(colorInit, curentG - colorTransfer, colorInit);
                }
                else if(curentG <= 1) {
                    GetComponent<Renderer>().material.color = new Color(colorInit, curentG + colorTransfer, colorInit);
                }
            }
        if (playerPos.magnitude <= 2)
        {
            //Application.LoadLevel("Assets/Scene/HorrorScene");
            SceneManager.LoadSceneAsync("Scene/HorrorScene");
        }
        playerPos = newDistance;
    }
}
