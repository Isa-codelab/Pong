using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolaController : MonoBehaviour
{
    public Transform transformCamera;

    public AudioClip somColisao;

    public Rigidbody2D rb;

    private Vector2 minhaVelocidade;

    public float velocidade = 5f;

    public float limiteHorizontal = 12f;
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
