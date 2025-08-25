using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class BolaTeste
{
   private BolaService _bolaService;

    [SetUp]
    public void Setup()
    {
        _bolaService = new BolaService();
    }

    [Test]
    public void ChecaJogoIniciado_DeveRetornarCorreto()
    {
        var delay = 0f;
        var jogoIniciado = false;

        // Primeira vez → deve retornar true
        Assert.IsTrue(_bolaService.ChecaJogoIniciado(delay, jogoIniciado));
    }

}
