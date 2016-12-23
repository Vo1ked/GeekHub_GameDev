using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class CameraOrbitMove : MonoBehaviour
{
    [SerializeField] private Transform RotationPoint;
    public float Sensity;

    private IEnumerator MouseControl()
    {
        for (;;)
        {
            float _XPos = Input.GetAxis("Horizontal");
            float _YPos = Input.GetAxis("Vertical");
            float _zoom = Input.GetAxis("Mouse ScrollWheel");
            if (_XPos != 0 || _YPos != 0 || _zoom !=0 )
            {
                transform.RotateAround(RotationPoint.position, new Vector3(0, _XPos, _YPos), Sensity*Time.deltaTime);
                transform.position = Vector3.MoveTowards(transform.position, RotationPoint.position, _zoom * Sensity);
            }
            yield return null;
        }
    }
	// Use this for initialization
	void Start () {
	    StartCoroutine(MouseControl());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
