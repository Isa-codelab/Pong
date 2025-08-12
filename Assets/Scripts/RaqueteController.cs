using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    // criando o meu vector 3 - classe que representa um ponto no espaço 3D
    private Vector3 minhapos;
    public float  meuEixoy;
    public float velocidade = 5f;
    public float meuLimite = 3.5f;

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

            //checar se o y é menor do que o limite
            if(meuEixoy < meuLimite)
            {
                //aumenta valor do meu y
                meuEixoy = meuEixoy + velocidade * Time.deltaTime;

            }

        };

        if(Input.GetKey(KeyCode.DownArrow) && meuEixoy > -meuLimite){

            //diminuir o valor do meu y
            meuEixoy = meuEixoy - velocidade * Time.deltaTime;
        };

    }
}
