using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MouseClickOnPlanet : MonoBehaviour
{
    private GameObject _selectedPlanet;

    [SerializeField] private GameObject _sunBurst;
    [SerializeField] private GameObject _planetName;
    [SerializeField] private GameObject _planetInfo;
    private bool _setActive;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 10000.0f))
            {
                hit.collider.transform.tag = "Select";
                Debug.Log(hit.collider.name);
                _selectedPlanet = GameObject.FindWithTag("Select");
                _planetName.GetComponent<Text>().text = _selectedPlanet.name;
                _planetInfo.GetComponent<Text>().text = "days pass "+_selectedPlanet.GetComponent<UIinfoAndSpeed>().RotateCount
                                                        + "\n"+ "Years Pass "+
                                                        _selectedPlanet.GetComponent<UIinfoAndSpeed>().OrbitCount;
                _selectedPlanet.transform.tag = "Untagged";

            }
        }
	    if (Input.GetButtonDown("Reload"))
	    {
	        _sunBurst.SetActive(_setActive);
	        _setActive = !_setActive;
        }
    }
}
