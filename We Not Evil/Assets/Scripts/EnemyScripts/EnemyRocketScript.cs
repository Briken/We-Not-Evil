using UnityEngine;
using System.Collections;

public class EnemyRocketScript : MonoBehaviour
{

    Vector3 currentPos;
    public GameObject player;
    public int deathTimer = 3;
    Vector3 bfg;
    float bombRad = 5.0f;

    // Use this for initialization
    void Start()
    {
                bfg = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        currentPos = Vector3.MoveTowards(this.gameObject.transform.position, player.gameObject.transform.position, 1.0f * Time.deltaTime);
    }

    IEnumerator BombTimer()
    {
        yield return new WaitForSeconds(deathTimer);
        ExplosionDamage(bfg, bombRad);
        Destroy(this.gameObject);
    }

     void ExplosionDamage(Vector3 centre, float radius) {
        Collider[] hitColliders = Physics.OverlapSphere(centre, radius);
        int i = 0;
        while (i < hitColliders.Length) {
            hitColliders[i].SendMessage("AddDamage");
            i++;
        }
    }
}
