using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour
{
    float mouseX;
    float mouseY;
    public int speed = 1;
    //Vector3 target;
    Vector2 targetPos;
    // Use this for initialization
	void Start () 
    {
        mouseX = Input.mousePosition.x;
        mouseY = Input.mousePosition.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
        targetPos.x = mouseX;
        targetPos.y = mouseY;
        //target = targetPos.transform.position;
        //target.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed*Time.deltaTime) ;
	}
}
