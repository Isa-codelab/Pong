using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    // criando o meu vector 3 - classe que representa um ponto no espa�o 3D
    private Vector3 minhapos;
    public float  meuEixoy;
    public float velocidade = 5f;
    public float meuLimite = 3.5f;

    void Start()
    {
        minhapos = transform.position; // pega a posi��o atual do objeto

    }

    void Update()
    {
        //passando o y 
        minhapos.y = meuEixoy;

        //modificar a posi��o da raquete
        transform.position = minhapos;


        //pegando a setinha para cima 
        if (Input.GetKey(KeyCode.UpArrow)){ 

            //checar se o y � menor do que o limite
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
