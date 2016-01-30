using UnityEngine;
using System.Collections;

public class BulletCollide : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnCollisionEnter(Collision collided)
    {
        if (collided.gameObject.tag == "enemy")
        {
            Destroy(collided.gameObject);
        }
        
   
    }
}
