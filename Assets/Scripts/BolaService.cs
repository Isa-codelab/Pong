using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaService
{
    public bool ChecaJogoIniciado( float delay, bool jogoiniciado) {

        if ( delay <= 0 && jogoiniciado == false)
        {
            return true;
        }
        else {   
            return false;
        }

    }


    public Vector2 PosiçãoRandomica( int direcao, float velocidade, Vector2 minhaVelocidade ) {
        if (direcao == 0)
        {
            minhaVelocidade.x = velocidade;
            minhaVelocidade.y = velocidade;
        }
        else if (direcao == 1)
        {
            minhaVelocidade.x = -velocidade;
            minhaVelocidade.y = velocidade;
        }
        else if (direcao == 2)
        {
            minhaVelocidade.x = velocidade;
            minhaVelocidade.y = -velocidade;
        }
        else
        {
            minhaVelocidade.x = -velocidade;
            minhaVelocidade.y = -velocidade;
        }

        return minhaVelocidade;

    }

}
