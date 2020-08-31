using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class EnemyHitDetect : MonoBehaviour
{
    public GameObject enemy;
    public GameObject self;
    public static int round = 2;
    public static int killCount = 1;
    //public static float speedIncrease = 1f;
    public GameObject player;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        //round = 1;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        GameObject enemyClone;
        killCount++;
        if(killCount == round)
        {
            player.GetComponent<PlayerMovement>().speed += .3f;
            this.GetComponent<NavMeshAgent>().speed += .5f;
            for(int i = 0; i<round; i++)
            {
                
                Vector3 vector = new Vector3(Random.Range(-11f, 39f), 1.75f, Random.Range(-3.9f, -24f));
                while(!(Vector3.Distance(vector, player.transform.position) < 10f))
                {
                    vector = new Vector3(Random.Range(-11f, 39f), 1.75f, Random.Range(-3.9f, -24f));
                }
                enemyClone = Instantiate(enemy, new Vector3(Random.Range(-11f, 39f), 1.75f, Random.Range(-3.9f, -24f)), enemy.transform.rotation);
            }
            round++;
            killCount = 1;
            score.text = (round-2).ToString();
            
            //speedIncrease++;

        }
        Destroy(self);
    }

    public void setData()
    {
        round = 2;
        killCount = 1;
    }
}
