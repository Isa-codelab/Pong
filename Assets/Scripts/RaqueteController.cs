using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{
    // criando o meu vector 3 - classe que representa um ponto no espa�o 3D
    public Vector3 minhapos;
    public float  meuEixoy;
    
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

    }
}
