using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    // criando o meu vector 3 - classe que representa um ponto no espaço 3D
    public Vector3 minhapos;
    public float  meuEixoy;
    
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

    }
}
