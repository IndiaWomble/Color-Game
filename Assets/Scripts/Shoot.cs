using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public float speed = 15.0f;
    public Pool p;

	// Use this for initialization
	void Start () {
        p = GameObject.FindWithTag("Player").GetComponent<Pool>();
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < 4.5f)
        {
            Vector2 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            transform.position = temp;
        }
        else
        {
            p.backtolist(gameObject);
        }
	}
}
