using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class ReliseMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButton("Ctrl"))
	    {
	        GetComponent<RigidbodyFirstPersonController>().mouseLook.XSensitivity = 0;
	        GetComponent<RigidbodyFirstPersonController>().mouseLook.YSensitivity = 0;
            GetComponent<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(false);

        }
        else if (!Input.GetButton("Ctrl"))
	    {
            GetComponent<RigidbodyFirstPersonController>().mouseLook.XSensitivity = 2;
            GetComponent<RigidbodyFirstPersonController>().mouseLook.YSensitivity = 2;
            GetComponent<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(true);

        }

    }
}
