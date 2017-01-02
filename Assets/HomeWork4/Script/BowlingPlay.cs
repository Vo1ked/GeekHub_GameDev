using UnityEngine;
using System.Collections;

public class BowlingPlay : MonoBehaviour
{
    public int PushingForse;
    public short GameStage ;

    IEnumerator ChangeXPos()
    {
        float xPos = -0.05f;
        for (;;)
        {
            if (GameStage == 1)
            {
                GetComponent<Rigidbody>().isKinematic = true;
                for (;;)
                {
                    if (transform.position.x < -0.7f)
                        xPos *= -1;
                    else if (transform.position.x > 1)
                        xPos *= -1;
                    GetComponent<Transform>().position += new Vector3(xPos, 0, 0); ;
                    yield return new WaitForSeconds(0.05f);
                    if (Input.GetButton("Fire1"))
                    {
                        GameStage = 3;
                        GetComponent<Rigidbody>().isKinematic = false;
                        yield return new WaitForSeconds(1);
                        break;
                    }
                }
            }
            yield return new WaitForFixedUpdate();
        }
    }

    //IEnumerator ChageAngle()
    //{
    //    for (;;)
    //    {
    //        float anglePos = 0.001f;
    //        Quaternion rotation = transform.parent.rotation;
    //        if (GameStage == 2)
    //        {
    //            gameObject.transform.Find("Angle").gameObject.SetActive(true);
    //            for (;;)
    //            {
    //                transform.parent.rotation = rotation;
    //                anglePos++;
    //                rotation[2] = anglePos;
    //                if (rotation.eulerAngles.y > 14)
    //                    anglePos *= -1;
    //                else if (rotation.eulerAngles.y < -345)
    //                    anglePos *= -1;
    //                yield return new WaitForSeconds(0.05f);
    //                if (Input.GetButton("Fire1"))
    //                {
    //                    gameObject.transform.Find("Angle").gameObject.SetActive(false);
    //                    GameStage = 3;
    //                    yield return new WaitForSeconds(1);
    //                    break;
    //                }

    //            }
    //        }
    //        yield return new WaitForFixedUpdate();
    //    }
    //}
    IEnumerator ChangeForse()
    {
        int force = 100;
        bool inMove;
        for (;;)
        {
            if (transform.position.z > 6f && transform.position.z < 41f)
                inMove = true;
            else
                inMove = false;
        if (Input.GetButton("Fire1") && GameStage == 3 && !inMove)
            {
                for (;;)
                {
                    if (PushingForse < 99)
                        force *= -1;
                    else if (PushingForse > 999)
                        force *= -1;
                    PushingForse += force;
                    yield return new WaitForSeconds(0.05f);
                    if (!Input.GetButton("Fire1"))
                    {
                        GetComponent<Rigidbody>().AddRelativeForce(0, 0,1 * PushingForse, ForceMode.Acceleration);
                        GameStage = 4;
                        break;
                    }
                }
            }

            yield return new WaitForFixedUpdate();
        }
    }

 

	// Use this for initialization
	void Start ()
	{
        StartCoroutine(ChangeXPos());
        //StartCoroutine(ChageAngle());
        StartCoroutine(ChangeForse());

        GameStage = 0;
	}

	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetButton("Use"))
            GameStage = 1;

	}
}
