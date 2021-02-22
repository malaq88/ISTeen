using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Frog : MonoBehaviour
{

    public Rigidbody2D play;
    public Text txtQuestao;
    public string resposta;
    public GameObject painelDialogo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        resposta = GameController.mensagemSapo;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Player"))
        {
            painelDialogo.SetActive(true);
            txtQuestao.text = resposta;
        }

    }

    public void OnTriggerExit2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Player"))
        {
            painelDialogo.SetActive(false);
        }
    }
}
