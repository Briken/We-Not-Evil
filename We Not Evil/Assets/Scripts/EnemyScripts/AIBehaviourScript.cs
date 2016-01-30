using UnityEngine;
using System.Collections;

public class AIBehaviourScript : MonoBehaviour
{


    //If the player enters the field of view of the enemy, the enemy will turn to the
    //player and open fire on them.

    /*
            Thus we need:
            1:A way for the player to be spotted.
            2:A way for the AI to attack the player-> Either by shooting, eating or blowing him up.
     */



    // 1. The player being spotted, and inducing a movement.



    Vector2 tempPos;

    public GameObject bullet;
    public GameObject rocket;







    IEnumerator Wait1Secs()
    {
        yield return new WaitForSeconds(2.0f);
        print("Waited for two seconds");
    }







    void OnTriggerStay2D(Collider2D player)//This is the trigger sphere around the AI.
    {
        //Here need to be coded, the different types of enemies.
        //Once the player is detected, the AI will move towards him whilst firing.

        if (this.gameObject.tag == "Gunner")
        {




            if (player.gameObject.transform.position.x < this.gameObject.transform.position.x)
            {
                //Here, the player is to the left of the AI, so the AI must head left and start firing.
                tempPos = this.gameObject.transform.position;
                tempPos.x -= 0.1f;
                this.gameObject.transform.position = tempPos;


            }

            if (player.gameObject.transform.position.x > this.gameObject.transform.position.x)
            {
                //Here, the player is to the right of the AI, so the AI must head right and start firing.
                tempPos = this.gameObject.transform.position;
                tempPos.x += 0.1f;
                this.gameObject.transform.position = tempPos;
            }

            //now start firing
            StartCoroutine(Wait1Secs());
            Instantiate(bullet, this.gameObject.transform.position, Quaternion.identity);//This makes a bullet, to be fired at the hero.

        }






        if (this.gameObject.tag == "Machinegunner")
        {

            if (player.gameObject.transform.position.x < this.gameObject.transform.position.x)
            {
                //Here, the player is to the left of the AI, so the AI must head left and start firing.
                tempPos = this.gameObject.transform.position;
                tempPos.x -= 1.0f;
                this.gameObject.transform.position = tempPos;
            }

            if (player.gameObject.transform.position.x > this.gameObject.transform.position.x)
            {
                //Here, the player is to the right of the AI, so the AI must head right and start firing.
                tempPos = this.gameObject.transform.position;
                tempPos.x += 1.0f;
                this.gameObject.transform.position = tempPos;
            }
        }







        if (this.gameObject.tag == "Melee")
        {

            if (player.gameObject.transform.position.x < this.gameObject.transform.position.x)
            {
                //Here, the player is to the left of the AI, so the AI must head left and start firing.
                tempPos = this.gameObject.transform.position;
                tempPos.x -= 1.0f;
                this.gameObject.transform.position = tempPos;
            }

            if (player.gameObject.transform.position.x > this.gameObject.transform.position.x)
            {
                //Here, the player is to the right of the AI, so the AI must head right and start firing.
                tempPos = this.gameObject.transform.position;
                tempPos.x += 1.0f;
                this.gameObject.transform.position = tempPos;
            }
        }






        if (this.gameObject.tag == "Suicider")
        {

            if (player.gameObject.transform.position.x < this.gameObject.transform.position.x)
            {
                //Here, the player is to the left of the AI, so the AI must head left and start firing.
                tempPos = this.gameObject.transform.position;
                tempPos.x -= 1.0f;
                this.gameObject.transform.position = tempPos;
            }

            if (player.gameObject.transform.position.x > this.gameObject.transform.position.x)
            {
                //Here, the player is to the right of the AI, so the AI must head right and start firing.
                tempPos = this.gameObject.transform.position;
                tempPos.x += 1.0f;
                this.gameObject.transform.position = tempPos;
            }
        }








        if (this.gameObject.tag == "Rocketeer")
        {

            if (player.gameObject.transform.position.x < this.gameObject.transform.position.x)
            {
                //Here, the player is to the left of the AI, so the AI must head left and start firing.
                tempPos = this.gameObject.transform.position;
                tempPos.x -= 1.0f;
                this.gameObject.transform.position = tempPos;
            }

            if (player.gameObject.transform.position.x > this.gameObject.transform.position.x)
            {
                //Here, the player is to the right of the AI, so the AI must head right and start firing.
                tempPos = this.gameObject.transform.position;
                tempPos.x += 1.0f;
                this.gameObject.transform.position = tempPos;
            }
        }































    }

















    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {







    }
}
