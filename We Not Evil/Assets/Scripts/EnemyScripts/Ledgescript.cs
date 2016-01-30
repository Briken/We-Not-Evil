using UnityEngine;
using System.Collections;

public class Ledgescript : MonoBehaviour
{


    public float moveLength = 0.1f;
    public bool movingLeft = true;
    public bool movingRight = false;

    Vector3 currentPosition;

    void Start()
    {
        currentPosition = this.gameObject.transform.position;

    }

    void Update()
    {
        if (movingLeft)
        {
            currentPosition.x -= moveLength * Time.deltaTime;
            this.gameObject.transform.position = currentPosition;
        }

        if (movingRight)
        {
            currentPosition.x += moveLength * Time.deltaTime;
            this.gameObject.transform.position = currentPosition;
        }


    }

    void OnCollisionEnter(Collision collision)
    {

        movingLeft = !movingLeft;
        movingRight = !movingRight;

    }
}
