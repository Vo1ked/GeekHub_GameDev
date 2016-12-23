using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIinfoAndSpeed : MonoBehaviour
{
    [SerializeField] private GameObject SpeedInfo;
    public int OrbitCount, RotateCount;




    // Use this for initialization
    void Start ()
    {
        OrbitCount = 0;
        RotateCount = 0;
	    
    }

    public void CounterOrbit()
    {
        OrbitCount++;
    }
    public void CounterRotate()
    {
        RotateCount++;

    }
    // Update is called once per frame
    void Update ()
	{
	    if (Input.GetButtonDown("Speed Up"))
	    {
            GetComponent<Animator>().speed++;
	        SpeedInfo.GetComponent<Text>().text = "Speed:  " + GetComponent<Animator>().speed;


	    }
	    if (Input.GetButtonDown("Speed Down") && GetComponent<Animator>().speed > 0)
	    {
            GetComponent<Animator>().speed--;
	        SpeedInfo.GetComponent<Text>().text = "Speed:  " + GetComponent<Animator>().speed;
	    }


    }
}
