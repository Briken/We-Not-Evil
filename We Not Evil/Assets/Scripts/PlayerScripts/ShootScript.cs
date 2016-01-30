using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour
{
    public GameObject fireSpot;
    public GameObject bullet;
    float mouseX;
    float mouseY;
    public static Vector3 targetPoint; 
	// Use this for initialization
	void Start () 
    {
    
	}
	
	// Update is called once per frame
	void Update ()
    {
       mouseX = Input.mousePosition.x;
       mouseY = Input.mousePosition.y;
       if (Input.GetMouseButtonDown(0))
       {
        mouseX = Input.mousePosition.x;         
        mouseY = Input.mousePosition.y;
        Instantiate(bullet, fireSpot.transform.position, Quaternion.identity);
       
        targetPoint = Camera.main.ScreenToWorldPoint(new Vector3(mouseX, mouseY, 0));
       }
	}
}
