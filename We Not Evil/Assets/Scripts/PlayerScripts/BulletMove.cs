using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour
{
   
    public int deathTimer = 2;
    public int speed = 1;
    Vector3 target;

    public GameObject cube;
    GameObject player;
    // Use this for initialization
	void Start () 
    {

        target = ShootScript.targetPoint;
        StartCoroutine(KillBullet());
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed*Time.deltaTime) ;
       
	}

    IEnumerator KillBullet()
    {
        yield return new WaitForSeconds(deathTimer);
        Destroy(this.gameObject);
    }
}
