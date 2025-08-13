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

    //identificar se é o player 1 ou 2
    public bool player1;


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

        float deltavelocidade = velocidade * Time.deltaTime;

        if (player1) {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //aumenta valor do meu y
                meuEixoy = meuEixoy + deltavelocidade;
            };

            if (Input.GetKey(KeyCode.DownArrow))
            {

                //diminuir o valor do meu y
                meuEixoy = meuEixoy - deltavelocidade;
            };

        }
        else
        {
            if(Input.GetKey(KeyCode.W))
            {
                //aumenta valor do meu y
                meuEixoy = meuEixoy + deltavelocidade;
                
            }
            if (Input.GetKey(KeyCode.S))
            {
                //diminuir o valor do meu y
                meuEixoy = meuEixoy - deltavelocidade;
            }
        }

        //limitar a raquete
        if(meuEixoy > meuLimite)
        {
            meuEixoy = meuLimite;
        }
        if (meuEixoy < -meuLimite)
        {
            meuEixoy = -meuLimite;
        }
    }
}
