using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public int speed = 2;
    public static bool isTarget = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*Vector2 v = rigidbody.velocity;
        if (Input.GetKey(KeyCode.A))
        {
            v.x = -speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            v.x = speed;
        }
        else
        {
            v.x = 0.0f;
        }
        rigidbody.velocity = v;*/
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            isTarget = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            isTarget = false;
        }
    }






}

