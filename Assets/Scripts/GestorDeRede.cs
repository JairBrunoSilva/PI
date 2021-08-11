using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;

public class GestorDeRede : MonoBehaviourPunCallbacks
{
   public static GestorDeRede Instancia { get; private set;  }
    private void Awake()
    {
        if(Instancia != null && Instancia != this)
        {
            gameObject.SetActive(false);
            return;
        }
        Instancia = this;
            DontDestroyOnLoad(gameObject);
    }

    internal void CriaSala(string text)
    {
        throw new NotImplementedException();
    }

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Conexão bem sucedida.");
    }

    public void CriaSalaEntrada(string nomeSala)
    {
        PhotonNetwork.CreateRoom(nomeSala);
    }

    public void JoinRoom(string nomeSala)
    {
        PhotonNetwork.JoinRoom(nomeSala);
    }

    public void MudaNick(string nickname)
    {
        PhotonNetwork.NickName = nickname;
    }

    public string ObterListaDejogadores()
    {
        var lista = "";
        foreach(var player in PhotonNetwork.PlayerList)
        {
            lista += player.NickName + "\n";
        }
        return lista;
    }

    public bool DonoDaSala()
    {
        return PhotonNetwork.IsMasterClient;
    }

}
