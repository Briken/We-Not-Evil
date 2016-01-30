using UnityEngine;
using System.Collections;

public class EnemyBulletScript : MonoBehaviour
{
    /*


        ATTACH THIS TO THE BULLETS FIRED BY THE GUNNER AND MACHINE GUNNER


     */
    Vector3 currentPos;
    GameObject player;


    IEnumerator Wait4Secs()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }





    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Cube");
        currentPos = Vector3.MoveTowards(this.gameObject.transform.position, player.gameObject.transform.position, 1.0f * Time.deltaTime);
        StartCoroutine(Wait4Secs());
    }

    // Update is called once per frame
    void Update()
    {
        //The bullets are spawned from the enemy Gunner and machinegunner.
        //Once they are instantiated, they fly towards the first item in the array

        currentPos = Vector3.MoveTowards(this.gameObject.transform.position, player.gameObject.transform.position, 1.0f * Time.deltaTime);


    }

    void OnColliderEnter(Collision collide) //Here is the collision detection, when the bullet collides
    {
        if (collide.gameObject.tag == "Player")
        {
            //Here we remove player health since the bullet hit us.
            Debug.Log("Player hit!");
        }
    }
}
 