using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScorePrint : MonoBehaviour {

    [SerializeField]
    private Transform _AllPins;

    // Use this for initialization
    void Start ()
    {
        GetComponent<Text>().text = "Score: 0 pins";

    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "Score: "+ _AllPins.GetComponent<PinReposition>().FalenPins + "pins";
	}
}
