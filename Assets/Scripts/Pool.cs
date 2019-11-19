using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour {

    List<GameObject> pool = new List<GameObject>();
    public Transform point;
    public GameObject obj;
    public int size = 20;

	// Use this for initialization
	void Start () {
        bulletins();
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            spawn();
        }
	}

    void bulletins()
    {
        for (int i = 0; i < size; i++)
        {
            var o = Instantiate(obj, point.position, Quaternion.identity);
            o.SetActive(false);
            pool.Add(o);
        }
    }

    void spawn()
    {
        pool[0].transform.position = new Vector2(point.position.x, point.position.y);
        pool[0].SetActive(true);
        pool.RemoveAt(0);
    }

    public void backtolist(GameObject g)
    { 
        if(g.activeInHierarchy)
        {
            g.SetActive(false);
            pool.Add(g);
        }
    }
}
