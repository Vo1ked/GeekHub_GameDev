using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerChange : MonoBehaviour
{
    [SerializeField]
    private Transform _BowlingBall;

    // Use this for initialization
    void Start()
    {
        GetComponent<Text>().text = "Score: 0 pins";
    }

// Update is called once per frame
void Update()
{
    GetComponent<Text>().text = "Power: " + _BowlingBall.GetComponent<BowlingPlay>().PushingForse;
}
}