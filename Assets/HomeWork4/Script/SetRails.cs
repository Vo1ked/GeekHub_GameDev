using UnityEngine;
using System.Collections;

public class SetRails : MonoBehaviour
{
    private short _Trigger;

    IEnumerator onOff()
    {
        for (;;)
        {
            if (Input.GetButton("P") && _Trigger == 0)
            {
                gameObject.transform.Find("LRail").gameObject.SetActive(false);
                gameObject.transform.Find("RRail").gameObject.SetActive(false);
                _Trigger = 1;
                yield return new WaitForSeconds(0.5f);
            }
            else if (Input.GetButton("P") && _Trigger == 1)
            {
                gameObject.transform.Find("LRail").gameObject.SetActive(true);
                gameObject.transform.Find("RRail").gameObject.SetActive(true);
                _Trigger = 0;
                yield return new WaitForSeconds(0.5f);
            }
            yield return new WaitForFixedUpdate();
        }
    }
	// Use this for initialization
	void Start ()
	{
        _Trigger = 0;
        StartCoroutine(onOff());

	}
	
	// Update is called once per frame
	void Update () {

    }
}
