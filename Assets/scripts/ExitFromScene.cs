using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitFromScene : MonoBehaviour {
    private Vector3 distance;
    private GameObject player;
    private Transform button;

    void Start () {
        player = GameObject.FindWithTag("Player");
        button = transform;
    }

		void Update () {
        distance = player.transform.position - button.position;
        if (Input.GetKey(KeyCode.F) && distance.magnitude < 2f)
	    {
	        SceneManager.LoadSceneAsync("Scene/MainScene");
	    }
	}
}
