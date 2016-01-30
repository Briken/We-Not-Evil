using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour
{
    public GameObject fireSpot;
    public GameObject bullet;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
       if (Input.GetMouseButtonDown(0))
       {
        Instantiate(bullet, fireSpot.transform.position, Quaternion.identity);

       }
	}
}
