using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float speed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Transform transform = gameObject.GetComponent<Transform>();
        Transform parentTransform = transform.parent.GetComponent<Transform>();
        float x = Input.GetAxis("Horizontal");
        Vector3 v;
        v = parentTransform.right * speed * x * Time.deltaTime;
        if ((Vector3.Scale(transform.position, parentTransform.right) + v).magnitude > 1.3f)
            v = Vector3.Scale(transform.position, parentTransform.right) *
                (1.3f - (Vector3.Scale(transform.position, Vector3.Scale(parentTransform.right, parentTransform.right))).magnitude);
        transform.Translate(v, Space.World);
	}
}
