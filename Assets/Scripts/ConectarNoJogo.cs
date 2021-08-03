using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;

public class ConectarNoJogo : MonoBehaviourPunCallbacks
{
    private float tempo = 5.0f;
    static public int salaCapacity;

    // Servem só pro posicionamento dos nomes dos personagens
    public GameObject n1, n2, n3;


    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Conectado ao server " + PhotonNetwork.CloudRegion + ".");
    }
    void Update()
    {
        if(salaCapacity == 3)
        {
            tempo -= Time.deltaTime;
        }
        if (tempo <= 0)
        {
            SceneManager.LoadScene("Game1Ano");
        }
    }
    //Biológicas
    void P1()
    {
        ControladorGeral.nomeP1 = ControladorGeral.nomeGener;
        //n1.transform.position = new Vector3(0, 2, 0); 
        //inicial: 260, 187, 0
        //requisitada: 0, 2, 0
    }
    //Exatas
    void P2()
    {
        ControladorGeral.nomeP2 = ControladorGeral.nomeGener;
    }
    //Humanas
    void P3()
    {
        ControladorGeral.nomeP3 = ControladorGeral.nomeGener;
    }
}