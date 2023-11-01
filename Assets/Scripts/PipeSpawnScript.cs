using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public  GameObject  pipe;
    public  float       intervalo = 3;
    private float       tempo;
    public  float       heightOffSet = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        InstanciandoPipe();
    }

    // Update is called once per frame
    void Update()
    {
        
        tempo = tempo + Time.deltaTime; //Colocando o tempo real na variável tempo
        if (tempo > intervalo)
        {
            InstanciandoPipe();
            tempo = 0;
        }



    }

    void InstanciandoPipe()
    {
        float menorPonto = transform.position.y - heightOffSet;
        float maiorPonto = transform.position.y + heightOffSet;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(menorPonto, maiorPonto), transform.position.z), transform.rotation);
        
    }

    
}
