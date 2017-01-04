using UnityEngine;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public class ScaryLookPumpkin : MonoBehaviour
{
    private GameObject player;
    private Transform lookingPoint;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
        lookingPoint = player.transform;
    }

	void Update ()
	{
        transform.LookAt(lookingPoint);
    }


}
