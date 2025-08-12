using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    // criando o meu vector 3 - classe que representa um ponto no espaço 3D
    private Vector3 minhapos;
    public float  meuEixoy;
    public float velocidade = 5f;

    void Start()
    {
        minhapos = transform.position; // pega a posição atual do objeto

    }

    void Update()
    {
        //passando o y 
        minhapos.y = meuEixoy;

        //modificar a posição da raquete
        transform.position = minhapos;


        //pegando a setinha para cima 
        if (Input.GetKey(KeyCode.UpArrow)){ 
            //aumenta valor do meu y
            meuEixoy = meuEixoy + velocidade * Time.deltaTime;

        };

        if(Input.GetKey(KeyCode.DownArrow)){
            //diminuir o valor do meu y
            meuEixoy = meuEixoy - velocidade * Time.deltaTime;
        };

    }
}
