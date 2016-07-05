using UnityEngine;
using System.Collections;

public class BallSpawn : MonoBehaviour {
    float time;
    public float spawnTime = 2f;
    public GameObject ball;
	// Use this for initialization
	void Start () {
        time = 100f;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time>spawnTime)
        {
            Instantiate(ball, transform.position, transform.rotation);
            time = 0f;
        }
	}
}
