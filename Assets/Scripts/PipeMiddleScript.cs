using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    private LogicScript _LogicScript; //Vari�vel de armazenamento do script "LogicScript"
    private BirdController _BirdController; //Vari�vel de armazenamento do script "BirdController"


    // Start is called before the first frame update
    void Start()
    {
        //Pegando o script LogicScript utilizando tags e colocando dentro da vari�vel _LogicScript
        _LogicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        //Pegando o script BirdController
        _BirdController = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdController>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8 && _BirdController.birdIsAlive) //Layer Bird, e a vari�vel birdIsAlive do script BirdController
        {
            _LogicScript.addScore(1); //Chamando o m�todo do script "LogicScript"

        }
        
    }
}
