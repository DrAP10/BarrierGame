using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {
    Vector3 direction;
    public float speed = 6f;
	// Use this for initialization
	void Start () {
        direction = (new Vector3(Random.Range(-1f, 1), 0f, Random.Range(-1f, 1f))).normalized;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(direction * speed * Time.deltaTime);
	}

    void OnCollisionEnter(Collision collision)
    {
        direction = Vector3.Reflect(direction, collision.contacts[0].normal);
    }
}
