using UnityEngine;
using System.Collections;
using System.Security.Cryptography;

public class RotationPump : MonoBehaviour {
    public Transform point;
    public float speed = 50F;
    public Light PumpkinShine;

    void Update()
    {
        transform.RotateAround(point.position, Vector3.back, speed * Time.deltaTime);
        transform.Rotate(0,speed * Time.deltaTime,0);
        PumpkinShine.GetComponent<Light>().intensity = Random.Range(0f, 2f);
    }
}
