using UnityEngine;
using System.Collections;

public class EnemyRocketScript : MonoBehaviour
{

    Vector3 currentPos;
    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        currentPos = Vector3.MoveTowards(this.gameObject.transform.position, player.gameObject.transform.position, 1.0f * Time.deltaTime);
    }
}
