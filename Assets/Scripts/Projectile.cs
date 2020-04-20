using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;

    public float target_x;
    private Vector3 target;

    // Use this for initialization
    void Start () {
        target = new Vector3(target_x, transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}
}
