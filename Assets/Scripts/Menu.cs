using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using Photon.Realtime;

using UnityEngine.UI;
        
public class Menu : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject _menuEntrada;
    [SerializeField] private GameObject _menuLobby;

    [SerializeField] public Text _nomeSala;
    [SerializeField] public Text _nomePlayer;

    private void Start()
    {
        _menuEntrada.gameObject.SetActive(false);
        _menuLobby.gameObject.SetActive(false);
    }

    public override void OnConnectedToMaster()
    {
        _menuEntrada.gameObject.SetActive(true);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Entrei na sala");
        //Debug.Log("Players já dentro da sala: ");
        //MudaMenu(_menuLobby.gameObject);
        //_menuLobby.AtualizaLista();
    }

    /*
    public void MudaMenu(GameObject menu)
    {
        _menuEntrada.gameObject.SetActive(false);
        _menuLobby.gameObject.SetActive(false);

        menu.SetActive(true);
    }
    */

    public void JoinLobbyButton()
    {
        Debug.Log("Iniciar game botão apertado.");
        _menuEntrada.SetActive(false);
        _menuLobby.SetActive(true);

        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 3;

        PhotonNetwork.JoinOrCreateRoom(_nomeSala.text, options, TypedLobby.Default);
    }

    private void Awake()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
}
