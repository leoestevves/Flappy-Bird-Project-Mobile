using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D birdRigidbody;
    public  int         jumpForce;

    private LogicScript _LogicScript;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        birdRigidbody = GetComponent<Rigidbody2D>();
        _LogicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Jump") && birdIsAlive) //Jump definido no project settings;
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }      

        if (transform.position.y > 17 || transform.position.y < -17)
        {
            _LogicScript.gameOver();
            birdIsAlive = false;
        }
    }
        
    public void Jump()
    {
        if (birdIsAlive)
        {
            birdRigidbody.velocity = Vector2.up * jumpForce;
        }         
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        _LogicScript.gameOver();
        birdIsAlive = false;
    }
}
