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

    public BolaService bolaService;

    void Start()
    {
        transform.position = Vector2.zero;
        bolaService = new BolaService();
    }

    void Update()
    {
        //iniciar a bola com delay
        delay = delay - Time.deltaTime;

        if (bolaService.ChecaJogoIniciado(delay, jogoiniciado))
        {
            jogoiniciado = true;

            int direcao = Random.Range(0, 4);

            minhaVelocidade = bolaService.PosiçãoRandomica(direcao, velocidade, minhaVelocidade);

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
