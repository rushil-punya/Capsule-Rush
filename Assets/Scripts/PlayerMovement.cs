using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    //movement//
    public CharacterController controller;

    public float speed = 12f;
    public float jumpSpeed = 3f;
    public float gravity = -9.81f;
    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = .4f;
    public LayerMask groundMask;

    bool isGrounded;
    
    public GameObject enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement[] enemies = GameObject.FindObjectsOfType<EnemyMovement>();
        foreach(EnemyMovement enemy in enemies)
        {
            if (Vector3.Distance(enemy.position, this.transform.position) < 1.5f)
            {
                SceneManager.LoadScene("EndGame");
                enemyCount.GetComponent<EnemyHitDetect>().setData();
            }
        }

        if(this.transform.position.y < -150f)
        {
            SceneManager.LoadScene("EndGame");
            enemyCount.GetComponent<EnemyHitDetect>().setData();
        }

        //movement and gravity//
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z; 
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded)
        {
            if(Input.GetKey("space"))
            {
                velocity.y = jumpSpeed;
            }
            if(velocity.y < 0)
            {
                velocity.y = -2f;
            }
            controller.Move(move* speed * Time.deltaTime);
        }
        else
        {
            controller.Move((transform.right * x * (speed-3f)+ transform.forward * z * (speed)) * Time.deltaTime);
        }
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        /******************************************/
        
    }
}
