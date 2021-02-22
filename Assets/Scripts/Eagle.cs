using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eagle : MonoBehaviour
{

    public Rigidbody2D play;
    public Text txtQuestao;
    public string dica;
    public GameObject painelDialogo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dica = GameController.mensagemAguia;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Player"))
        {
            painelDialogo.SetActive(true);
            txtQuestao.text = dica;
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
