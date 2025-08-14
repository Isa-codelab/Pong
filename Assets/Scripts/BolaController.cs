using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolaController : MonoBehaviour
{
    public bool jogoiniciado = false;

    public float delay = 3f;

    public Transform transformCamera;

    public AudioClip somColisao;

    public Rigidbody2D rb;

    private Vector2 minhaVelocidade;

    public float velocidade = 5f;

    public float limiteHorizontal = 12f;
   
    void Start()
    {
        transform.position = Vector2.zero;
    }

    void Update()
    {
        //iniciar a bola com delay
        delay = delay - Time.deltaTime;



        if(delay <= 0 && jogoiniciado == false)
        {
            jogoiniciado = true;

            int direcao = Random.Range(0, 4);

            if(direcao == 0)
            {
                minhaVelocidade.x = velocidade;
                minhaVelocidade.y = velocidade;
            }
            else if(direcao == 1)
            {
                minhaVelocidade.x = -velocidade;
                minhaVelocidade.y = velocidade;
            }
            else if(direcao == 2)
            {
                minhaVelocidade.x = velocidade;
                minhaVelocidade.y = -velocidade;
            }
            else
            {
                minhaVelocidade.x = -velocidade;
                minhaVelocidade.y = -velocidade;
            }

            rb.velocity = minhaVelocidade;
        }


        //checando se a bola saiu da tela
        if (transform.position.x > limiteHorizontal || transform.position.x < -limiteHorizontal)
        {
            Debug.LogError("Acabou o jogo");

            //recarrega a cena
            SceneManager.LoadScene("Game");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(somColisao, transformCamera.position);
    }
}
