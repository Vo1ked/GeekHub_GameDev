using UnityEngine;
using System.Collections;

public class OnOffOrbitLine : MonoBehaviour
{
    [SerializeField]
    private GameObject ParentOfAllOrbit;
    private bool _switch;
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetButtonDown("Use"))
	    {
	       ParentOfAllOrbit.SetActive(_switch);
            _switch = !_switch;
        }
	}
}
