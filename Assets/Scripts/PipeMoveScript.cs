using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float pipeSpeed;
    public float limiteDestruicao;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeSpeed ) * Time.deltaTime; //Multiplicando por time.deltaTime para não variar de pc para pc

        if (transform.position.x < limiteDestruicao)
        {
            Destroy(gameObject);
        }
    }
}
