using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SalaController : MonoBehaviour
{

    public static string pergunta;
    public static string resposta;
    public static string respostaErro;
    public GameObject painelDialogo;
    public Text txtQuestao;


    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Sala_1")
        {
            pergunta = "Então me responda quais dessas doenças não são transmitidas pela prática de sexo não" +
                "\nsegura?" +
                "\na) Sífilis;" +
                "\nb) Leishmaniose;" +
                "\nc) Tricomoníase;" +
                "\nd) Clamídia.";

            resposta = "Correto! Siga para a próxima fase.";

            respostaErro = "Errado! " +
                "\nResposta Correta: Opção 'B'";

        }
        else if (SceneManager.GetActiveScene().name == "Sala_2")
        {
            pergunta = "São IST:" +
                "\na) Aids, HPV, Herpes genital;" +
                "\nb) Gonorreia, Sífilis, Lúpus;" +
                "\nc) Cancro mole, Hepatite C, Diabetes;" +
                "\nd) Lúpus, Aids, Gonorreia.";

            resposta = "Correto! Siga para a próxima fase.";

            respostaErro = "Errado! " +
                "\nResposta Correta: Opção 'A'";
        }
        else if (SceneManager.GetActiveScene().name == "Sala_3")
        {
            pergunta = "\nQuais dessas doenças são transmitidas na hora do parto? " +
                "\na) Sífilis, HPV, Aids" +
                "\nb) Hepatite B e C" +
                "\nc) Herpes genital, Gonorreia." +
                "\nd) Todas";

            resposta = "Correto! Siga para a próxima fase.";

            respostaErro = "\nErrado! " +
                "\nResposta Correta: Opção 'D'";
        }
        else if (SceneManager.GetActiveScene().name == "Sala_4")
        {
            pergunta = "Como se pega uma IST?" +
                "\na) Roupas íntimas;" +
                "\nb) Pelo beijo;" +
                "\nc) Pelo ar;" +
                "\nd) Relação sexual desprotegida.";

            resposta = "Correto! Siga para a próxima fase.";

            respostaErro = "\nErrado! " +
                "\nResposta Correta: Opção 'D'";
        }
        else if (SceneManager.GetActiveScene().name == "Sala_5")
        {
            pergunta = "Quais as principais situações que aumentam o risco de se pegar uma IST são:" +
                "\na) Pessoas que usam drogas injetáveis e compartilham agulhas e seringas;" +
                "\nb) Pessoas que têm relações sexuais sem usar camisinha masculina e ou feminina;" +
                "\nc) Pessoas cujo companheiro ou companheira tem relação sexual com outras pessoas sem usar camisinha;" +
                "\nd) Todas as alternativas estão corretas.";

            resposta = "Correto! Siga para a próxima fase.";

            respostaErro = "\nErrado! " +
                "\nResposta Correta: Opção 'D'";
        }
        else if (SceneManager.GetActiveScene().name == "Sala_6")
        {
            pergunta = "Como se previne uma IST, e duas dessas infecções." +
                "\na) Anticoncepcional; gonorreia e HPV;" +
                "\nb) Coito interrompido; tricomoníase e hepatite B;" +
                "\nc) Camisinha masculina ou feminina; sifilis e Aids;" +
                "\nd) Pílula do dia seguinte; herpes genital e HPV.";

            resposta = "Correto! Siga para a próxima fase.";

            respostaErro = "\nErrado! " +
                "\nResposta Correta: Opção 'C'";
        }
        else if (SceneManager.GetActiveScene().name == "Sala_7")
        {
            pergunta = "O uso correto da camisinha durante a relação sexual pode prevenir infecções, como:" +
                "\na) Gonorreia, Aids e sífilis;" +
                "\nb) Tétano, herpes genital e diarréia;" +
                "\nc) Sarampo, HPV e candidíase;" +
                "\nd) Aids, hepatite e catapora.";

            resposta = "Correto! Siga para a próxima fase.";

            respostaErro = "\nErrado! " +
                "\nResposta Correta: Opção 'A'";
        }
        else if (SceneManager.GetActiveScene().name == "Sala_8")
        {
            pergunta = "Dentre as IST, existe vacinação para:" +
                "\na) Hepatite e herpes genital;" +
                "\nb) Aids e tricomoníase;" +
                "\nc) Sífilis e gonorreia;" +
                "\nd) HPV e Hepatite B.";

            resposta = "Correto! Siga para a próxima fase.";

            respostaErro = "\nErrado! " +
                "\nResposta Correta: Opção 'D'";
        }
        else if (SceneManager.GetActiveScene().name == "Sala_9")
        {
            pergunta = "Qual das alternativas não indica a presença de uma IST?" +
                "\na) Verruga genital;" +
                "\nb) Tosse;            " +
                "\nc) Sangramento genital;" +
                "\nd) Secreção genital.";

            resposta = "Correto! Siga para a próxima fase.";

            respostaErro = "\nErrado! " +
                "\nResposta Correta: Opção 'B'";
        }
        else if (SceneManager.GetActiveScene().name == "Sala_10")
        {
            pergunta = "Manchas no corpo, que geralmente não coçam, incluindo palmas das mãos e plantas dos pés, podendo " +
                "\nser acompanhadas de febre, mal-estar, dor de cabeça e ínguas pelo corpo são sintomas de: " +
                "\na) Gonorreia;" +
                "\nb) Sífilis;" +
                "\nc) Tricomoníase;" +
                "\nd) HPV.";

            resposta = "Correto! Siga para a próxima fase.";

            respostaErro = "\nErrado! " +
                "\nResposta Correta: Opção 'B'";
        }
        else if (SceneManager.GetActiveScene().name == "Sala_0")
        {
            pergunta = "Seja bem vindo!" +
                "\n Utilize a tela <ESPAÇO> para pular" +
                "\n e as teclas ← e → para se movimentar para esquerda ou direita" +
                "\n acerte umas das opções de A a D para escolher uma resposta";

            resposta = "Muito bem! " +
                "\n você entendeu." +
                "\n \n Siga para a próxima fase.";

            respostaErro = "\nErrado! " +
                "\nResposta Correta: Opção 'B'";
        }

        painelDialogo.SetActive(true);
        txtQuestao.text = pergunta;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
