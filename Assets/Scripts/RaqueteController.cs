using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Runtime.CompilerServices;




public class RaqueteController : MonoBehaviour
{
    public Transform bolaTranform;

    // se for true, a raquete segue a bola automaticamente
    public bool automatico = false;

    // criando o meu vector 3 - classe que representa um ponto no espaço 3D
    private Vector3 minhapos;

    public float meuEixoy;
    public float velocidade = 5f;
    public float meuLimite = 3.5f;

    //identificar se é o player 1 ou 2
    public bool player1;

    private RaqueteLogicGame raqueteLogic;
    void Start()
    {
        minhapos = transform.position; // pega a posição atual do objeto
        raqueteLogic = new RaqueteLogicGame();
    }

    void Update()
    {

        float deltavelocidade = velocidade * Time.deltaTime;

        if (player1)
        {
            meuEixoy = raqueteLogic.PressKeyPlayer1(meuEixoy, deltavelocidade, Input.GetKey(KeyCode.W), Input.GetKey(KeyCode.S));
        }
        else
        {
            automatico = raqueteLogic.KeyReturnInputPlayer2(automatico, Input.GetKey(KeyCode.Return));

            if (!automatico)
            {
                meuEixoy = raqueteLogic.KeyUpArrowInputPlayer2(meuEixoy, deltavelocidade, Input.GetKey(KeyCode.UpArrow));
                meuEixoy = raqueteLogic.KeyDownInputPlayer2(meuEixoy, deltavelocidade, Input.GetKey(KeyCode.DownArrow));
            }
            else
            {
                meuEixoy = raqueteLogic.MoverAutomatico(meuEixoy, bolaTranform.position.y);
                automatico = raqueteLogic.InputAutomaticoFalse(automatico, Input.GetKey(KeyCode.UpArrow), Input.GetKey(KeyCode.DownArrow));
            }
        }

        meuEixoy = raqueteLogic.LimitarRaquete(meuEixoy, meuLimite);

        minhapos = transform.position;
        minhapos.y = meuEixoy;
        transform.position = minhapos;

    }

}

   