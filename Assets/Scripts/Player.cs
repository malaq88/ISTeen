using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public static float vida;
    public float velocidade;
    public string jogador;
    public int forcaX;
    public bool pula;
    public int pulo;
    public Rigidbody2D play;
    public Text txtQuestao;
    public string resposta;
    public bool respondeu;
    public bool comDica;
    public GameObject painelDialogo;

    // Start is called before the first frame update
    void Start() {
        forcaX = 250;
        velocidade = 2.5f;
        pulo = 1;
        pula = true;
        comDica = false;
        respondeu = false;
        if (SalvaValores.vidaSalva != 0)
        {
            vida = SalvaValores.vidaSalva;
        } else
        {
            vida = 10;
        }
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("Text: " + vida);
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        float movimento = Input.GetAxis("Horizontal");

        rigidbody.velocity = new Vector2(movimento*velocidade, rigidbody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) {
            if (pulo > 0)
            {
                rigidbody.AddForce(new Vector2(0, forcaX));
                GetComponent<Animator>().SetBool("Pulo", true);
                GetComponent<Animator>().SetBool("Walked", false);
                pulo--;
                GetComponent<AudioSource>().Play();
            }
            
        }

        if (Input.GetKeyUp(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            GetComponent<Animator>().SetBool("Pulo", false);
        }

        if (movimento < 0) {
            GetComponent<SpriteRenderer>().flipX = true;
        } else if (movimento > 0) {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (movimento > 0 || movimento < 0 ) {
            GetComponent<Animator>().SetBool("Walked", true);
        } else {
            GetComponent<Animator>().SetBool("Walked", false);
        }

        
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("Chao"))
        {
            pula = true;
            pulo = 1;
        } else if (outro.gameObject.CompareTag("Correta") && respondeu == false)
        {
            Destroy(outro.gameObject);
            resposta = SalaController.resposta;
            txtQuestao.text = resposta;
            respondeu = true;
        } else if (outro.gameObject.CompareTag("Incorreta") && respondeu == false)
        {
            //Destroy(outro.gameObject);
            resposta = SalaController.respostaErro;
            txtQuestao.text = resposta;
            vida = vida - 1.4f;
            respondeu = true;
        }

    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Dica"))
        {
            comDica = true;
        }
        if (outro.gameObject.CompareTag("Questao") && comDica == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (outro.gameObject.CompareTag("Saida") && respondeu == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        SalvaValores.vidaSalva = vida;
    }

}
