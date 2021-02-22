using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static string mensagemSapo;
    public static string mensagemAguia;
    public static string mensagemInicio;

    public float nota;
    public GameObject painelDialogo;
    public Text txtQuestao;
    public string resposta;

    void Start()
    {
        nota = Player.vida;

        if (SceneManager.GetActiveScene().name == "Fase_1")
        {
            mensagemInicio = "Seja bem vindo ao ISTeen, na próxima " +
                "casinha há uma questão para você responder, mas antes, " +
                "suba nas plataformas para pegar uma dica valiosa com a águia";

            mensagemSapo = "Na próxima casinha há uma pergunta para você responder, " +
                "mas antes, suba nas plataformas para pegar uma dica valiosa com a águia Rêus!";

            mensagemAguia = "É importante se cuidar e ter responsabilidade com o exercício da prática sexual. Pois, quando " +
                "não se cuida, além de uma gravidez/ e paternidade precoce, pode adquirir qualquer doença, " +
                "como uma INFECÇÃO SEXUALMENTE TRANSMISSÍVEL. São elas: HIV / Aids, HPV, " +
                "Clamídia, Gonorreia, Herpes genital, Sífilis, Tricomoníase, Donovanose e " +
                "Hepatite.";

        } else if (SceneManager.GetActiveScene().name == "Fase_2")
        {
            mensagemSapo = "Ótimo, se você chegou até aqui, continue para resolver as demais questões.";

            mensagemAguia = "Conhecida popularmente por DST ou IST, as Infecções Sexualmente Transmissíveis" +
                " são doenças antigamente conhecidas como doenças venéreas.";

        } else if (SceneManager.GetActiveScene().name == "Fase_3")
        {
            mensagemSapo = "Boa! Sobre a pilha de blocos logo à frente está o esquilo Siffh pra você pegar mais uma dica para a próxima pergunta...";

            mensagemAguia = "As IST são transmitidas principalmente pela prática de sexo não seguro com uma pessoa que esteja " +
                "infectada. Podendo também ser transmitida pelo sangue, e de mãe para filho durante a gestação ou no momento do parto.";

        } else if (SceneManager.GetActiveScene().name == "Fase_4")
        {
            mensagemSapo = "Dentro dessa caverna está a formiga Tonton, encontre-a para mais uma dica.";

            mensagemAguia = "Os riscos de se contaminar com algumas IST são durante as práticas sexuais não seguras, principalmente quando" +
                " se faz uso de bebidas alcoólicas em festas com seus pares e se sentindo descontraídos e a vontade não avaliando os riscos e " +
                "consequências.";

        } else if (SceneManager.GetActiveScene().name == "Fase_5_6")
        {
            mensagemSapo = "Encontre a formiga Tonton novamente, ela tem mais uma dica.";

            mensagemAguia = "Algumas IST podem não apresentar sintomas, tanto no menino quanto na menina, por isso, quando fizerem sexo sem" +
                " camisinha deve procurar o serviço de saúde para consultas e acompanhamento com um profissional da saúde. " +
                "Dentre as IST, existem vacinas para o HPV, que é indicada para meninas de 9 a 14 anos e meninos de 11 a 14 anos," +
                " e para a Hepatite B, para todas as idades.";

        } else if (SceneManager.GetActiveScene().name == "Fase_7")
        {
            mensagemSapo = "Ufa! Finalmente estamos de volta à superfície. Suba as plataformas para encontrar novamente o esquilo Siffh.";

            mensagemAguia = "As Infecções Sexualmente Transmissíveis (IST) podem se manifestar de várias formas, sendo a maioria localizada na região genital." +
                " Por isso é importante que o corpo seja observado durante a higiene pessoal, o que pode ajudar a identificar uma IST no estágio inicial.";
        }

       //Debug.Log("Nota" + nota);
        if (nota < 6)
        {
            resposta = "Sua pontuação foi: "+nota+", estude mais e tente outra vez." +
                "\n" +
                "\n" +
                "pressione Esc para sair.";
        } else if (nota < 1)
        {
            resposta = "Você não acertou nenhuma questão, estude mais e tente outra vez." +
                "\n" +
                "\n" +
                "pressione Esc para sair.";
        } else if (nota >= 6) 
        {
            resposta = "Parabens sua pontuação foi " + nota + " muito bom!!!" +
                "é um ótimo resultado" +
                "\n" +
                "\n" +
                "pressione Esc para sair.";
        }
        else
        {
            resposta = "Você não acertou nenhuma questão, estude mais e tente outra vez." +
                "\n" +
                "\n" +
                "pressione Esc para sair.";
        }

        if (SceneManager.GetActiveScene().name == "Encerramento")
        {
            painelDialogo.SetActive(true);
            txtQuestao.text = resposta;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && SceneManager.GetActiveScene().name == "Abertura")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
