using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 temp = gameObject.transform.position;
            if(Input.GetKey(KeyCode.RightArrow) && temp.x < 11.0f)
            {
                temp.x += speed * Time.deltaTime; 
                transform.position = temp;
            }
        if (Input.GetKey(KeyCode.LeftArrow) && temp.x > -11.0f)
        {
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;
        }
    }
}
