using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour
{
   
    public int deathTimer = 2;
    public int speed = 1;
    Vector3 targetPoint;

    //Vector3 target;
    Vector2 targetPos;
    public GameObject cube;

    // Use this for initialization
	void Start () 
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        Camera camera = GetComponent<Camera>();
        targetPoint = camera.ScreenToWorldPoint(new Vector3(mouseX, mouseY,0));
        Instantiate(cube, new Vector3(mouseX, mouseY, 0), Quaternion.identity);
        StartCoroutine(KillBullet());
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        //target = targetPos.transform.position;
        //target.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed*Time.deltaTime) ;
       
	}

    IEnumerator KillBullet()
    {
        yield return new WaitForSeconds(deathTimer);
        Destroy(this.gameObject);
    }
}
