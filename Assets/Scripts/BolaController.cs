using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 minhaVelocidade;

    public float velocidade = 5f;
    // Start is called before the first frame update
    void Start()
    {
        minhaVelocidade.x = velocidade;
        minhaVelocidade.y = velocidade;

        rb.velocity = minhaVelocidade;

        int direcao = Random.Range(0, 4);

        switch(direcao)
        {
            case 0:
                minhaVelocidade.x = velocidade;
                minhaVelocidade.y = velocidade;
                break;
            case 1:
                minhaVelocidade.x = -velocidade;
                minhaVelocidade.y = velocidade;
                break;
            case 2:
                minhaVelocidade.x = velocidade;
                minhaVelocidade.y = -velocidade;
                break;
            case 3:
                minhaVelocidade.x = -velocidade;
                minhaVelocidade.y = -velocidade;
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
