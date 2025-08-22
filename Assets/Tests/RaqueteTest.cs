using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class RaqueteTest
{
    RaqueteLogicGame gameLogic;
    [SetUp]
    public void Setup()
    {
        gameLogic = new RaqueteLogicGame();
    }
    // A Test behaves as an ordinary method
    [Test]
    public void LimitarRaquete_meuLimite_EixoYMaiorQueLimite()
    {
       
       var limite = 3.5f;
       var eixoY = 4.0f;

       var resultado = gameLogic.LimitarRaquete(eixoY, limite);

       Assert.AreEqual(limite, resultado);
    }

    [Test]
    public void LimitarRaquete_meuLimite_EixoYMenorQueLimite()
    {
       
       var limite = 3.5f;
       var eixoY = -4.0f;
       var resultado = gameLogic.LimitarRaquete(eixoY, limite);
       Assert.AreEqual(-limite, resultado);
    }

    [Test]
    public void PressKeyPlayer1_PressionaTeclaW_EixoYAumenta()
    {
       
       var eixoY = 0.0f;
       var deltaV = 0.1f;

       var pressionaW = true;
       var pressionaS = false;

       var resultado = gameLogic.PressKeyPlayer1(eixoY, deltaV, pressionaW, pressionaS);
       Assert.Greater(resultado, eixoY);
    }

    [Test]
    public void PressKeyPlayer1_PressionaTeclaS_EixoYDiminui()
    {
       
       var eixoY = 0.0f;
       var deltaV = 0.1f;
       var pressionaW = false;
       var pressionaS = true;
       var resultado = gameLogic.PressKeyPlayer1(eixoY, deltaV, pressionaW, pressionaS);
       Assert.Less(resultado, eixoY);
    }

    [Test]
    public void KeyDownInputPlayer2_PressDwon_EixoyDiminui()
    {
        float eixoy = 2.0f;
        float deltav = 2.0f;

        bool presskeydown = true;

        var resultado = gameLogic.KeyDownInputPlayer2(eixoy, deltav, presskeydown);

        Assert.Less(resultado, eixoy);
    }

    [Test]
    public void KeyUpInputPlayer2_PressUp_EixoYAumenta()
    {
        float eixoy = 1.0f;
        float deltav = 1.0f;

        bool presskeyup = true;

        var resultado = gameLogic.KeyUpArrowInputPlayer2(eixoy, deltav, presskeyup);

        Assert.Greater(resultado, eixoy);
    }

    [Test]
    public void KeyReturnInputPlayer2_PressReturn_AutomaticoTrue()
    {
        bool automatic = false;
        bool pressKeyReturn = true;
        var resultado = gameLogic.KeyReturnInputPlayer2(automatic, pressKeyReturn);
        Assert.IsTrue(resultado);
    }

    [Test]
    public void InputAutomaticoFalse_PressUP_False() { 
        var automatico = true;
        var tecla1 = true;
        var tecla2 = false;

        var resultado = gameLogic.InputAutomaticoFalse(automatico, tecla1, tecla2);

        Assert.IsFalse(resultado);

    }

    [Test]
    public void InputAutomaticoFalse_PressDown_False()
    {
        var automatico = true;
        var tecla1 = false;
        var tecla2 = true;

        var resultado = gameLogic.InputAutomaticoFalse(automatico, tecla1, tecla2);

        Assert.IsFalse(resultado);

    }

}
