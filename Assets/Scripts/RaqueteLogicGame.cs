using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteLogicGame
{
    // Start is called before the first frame update
    public float MoverAutomatico(float eixoAtual, float bolaY)
    {
        return Mathf.Lerp(eixoAtual, bolaY, 0.1f);
    }

    public float LimitarRaquete(float eixoY, float limite)
    {
        if (eixoY > limite)
        {
            return limite;
        }
        if (eixoY < -limite)
        {
            return -limite;
        }
        return eixoY;
    }

    public bool InputAutomaticoFalse(bool isAutomatico, bool tecla1, bool tecla2)
    {
        if (tecla1 || tecla2)
        {
            return false;
        }
        return isAutomatico;
    }

    public bool KeyReturnInputPlayer2( bool automatic, bool pressKeyReturn)
    {
        if (pressKeyReturn)
        {
           automatic = true;
        }

        return automatic;
    }


    public float KeyUpArrowInputPlayer2(float eixoy, float deltav, bool pressKeyUp)
    {
        if (pressKeyUp)
        {
            eixoy += deltav;
        }
        return eixoy;
    }

    public float KeyDownInputPlayer2(float eixoy, float deltav, bool pressKeyDown)
    {
        if (pressKeyDown)
        {
            eixoy -= deltav;
        }
        return eixoy;
    }

    public float PressKeyPlayer1(float eixoy, float deltav, bool presskeyW, bool pressKeyS)
    {
        if (presskeyW)
        {
            eixoy += deltav;
        }
        else if (pressKeyS)
        {
            eixoy -= deltav;
        }

        return eixoy;
    }

   
}

