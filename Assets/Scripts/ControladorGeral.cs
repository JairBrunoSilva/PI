using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorGeral : MonoBehaviour
{
    public int provatual = 0;
    // 9 = exatas (1)
    // 10 = biológicas (1)
    // 11 = humanas (1)
    //  = exatas (2)
    //  = biológicas (2)
    //  = humanas (2)
    //  = exatas (3)
    //  = biológicas (3)
    //  = humanas (3)
    //  = exatas (Enem)
    //  = biológicas (Enem)
    //  = humanas (Enem)

    [SerializeField] InputField nomie, salia;

    static public string nomeP1, nomeP2, nomeP3, nomeGener;
    public Text nome1, nome2, nome3;
    static public string sala;
    public bool gameBadEnd;

    void Start()
    {
        provatual = 9;
    }
    void Update()
    {
        if (P1NAOprova.provaconfirm1 && P2NAOprova.provaconfirm2 && P3NAOprova.provaconfirm3)
        {
            SceneManager.LoadScene(provatual);
        }

        if (P1NAOprova.sanityBio <=20 && P3NAOprova.sanityHum<=20 && P2NAOprova.sanityExa <=20)
        {
            gameBadEnd = true;
        }

        nomie.text = PlayerPrefs.GetString(nomeGener);
        salia.text = PlayerPrefs.GetString(sala);

        nome1.text = nomeP1;
        nome2.text = nomeP2;
        nome3.text = nomeP3;
    }
}