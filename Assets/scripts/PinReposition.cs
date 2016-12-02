using UnityEngine;
using System.Collections;
using Microsoft.Win32.SafeHandles;
using UnityEditor;

public class PinReposition : MonoBehaviour
{
    [SerializeField]
    private Transform _bowlingBall;

    private Transform[] _pins;

    private Vector3[] _originalPositions;
    private Vector3 _originalBowlingBallPos;


    private byte _countEnd;
    public int FalenPins ;

    IEnumerator CountPins()
    {
        for (;;)
        {
            if (_bowlingBall.position.z > 41 && _countEnd == 0)
            {
                yield return new WaitForSeconds(2f);
                for (int i = 0; i < _pins.Length; i++)
                {
                    if (( _pins[i].transform.GetChild(0).position[1] > 0.01f ||
                        _pins[i].transform.GetChild(0).position[1] < - 0.01f) )//&& FalenPins != 10)
                    {
                        FalenPins += 1;
                    }

                }
                _countEnd = 1;
            }
            yield return new WaitForFixedUpdate();
        }
    }
    // Use this for initialization
    void Start ()
    {
        var childCount = transform.childCount;
        FalenPins = 0;
        _pins = new Transform[childCount];
        for (int i = 0; i < childCount; i++)
        {
            _pins[i] = transform.GetChild(i);
        }

        _originalPositions = new Vector3[childCount];
        for (int i = 0; i < _pins.Length; i++)
        {
            _originalPositions[i] = _pins[i].transform.position;

        }
        _originalBowlingBallPos = _bowlingBall.transform.position;
        StartCoroutine(CountPins());
    }
	
	// Update is called once per frame
	void Update () {

	    if (Input.GetButtonDown("Reload"))
	    {
	        for (int i = 0; i < _pins.Length; i++)
	        {
                _pins[i].GetComponent<Rigidbody>().isKinematic = true;
                _pins[i].position = _originalPositions[i];
                _pins[i].rotation = new Quaternion(0, 0, 0, 0);
                _pins[i].GetComponent<Rigidbody>().isKinematic = false;
            }
	        _bowlingBall.GetComponent<Rigidbody>().isKinematic = true;
            _bowlingBall.GetComponent<Transform>().position = _originalBowlingBallPos;
            _bowlingBall.GetComponent<Transform>().parent.rotation = new Quaternion(0, 0, 0, 0);
            _bowlingBall.GetComponent<Transform>().rotation = new Quaternion(0, 0, 0, 0);
            _bowlingBall.GetComponent<Rigidbody>().isKinematic = false;
            _bowlingBall.GetComponent<BowlingPlay>().PushingForse = 100;
            _bowlingBall.GetComponent<BowlingPlay>().GameStage = 1;
	        FalenPins = 0;
            _countEnd = 0;
        }
        
	}
}
