using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Photon.Pun;
using Photon.Realtime;

public class GameConection : MonoBehaviourPunCallbacks
{
    public Text chatLog;

    
    private void Awake()
    {
        chatLog.text += "\nConectando ao servidor...";
        PhotonNetwork.LocalPlayer.NickName = "Uggo_" + Random.Range(1, 1000);
        PhotonNetwork.ConnectUsingSettings();
    }
    //------------------------------------------------------------------------------------------
    public override void OnConnectedToMaster()
    {

        chatLog.text += "\nConectado ao servidor!";

        if (PhotonNetwork.InLobby == false)
        {
            chatLog.text += "\nEntrando no lobby...";
            PhotonNetwork.JoinLobby();
        }
    }
    //------------------------------------------------------------------------------------------
    public override void OnJoinedLobby()
    {
        chatLog.text += "\nEntrei no Lobby!";

        chatLog.text += "\nEntrando na sala Uggo...";
        PhotonNetwork.JoinRoom("Uggo");

    }

    //------------------------------------------------------------------------------------------
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        chatLog.text += "\nErro ao entrar na sala: !" + message + " | codigo:" + returnCode;

        if (returnCode == ErrorCode.GameDoesNotExist)
        {
            chatLog.text += "\nCriando sala Uggo...";

            RoomOptions roomOptions = new RoomOptions { MaxPlayers = 20 };
            PhotonNetwork.CreateRoom("Uggo", roomOptions, null);
        }
    }

    public override void OnLeftRoom()
    {
        chatLog.text += "\nVocê saiu da sala Uggo";
    }
    //------------------------------------------------------------------------------------------
    public override void OnJoinedRoom()
    {
        chatLog.text += "\nVocê entrou na sala Uggo! Seu NickName é:" + PhotonNetwork.LocalPlayer.NickName;
    }
    //------------------------------------------------------------------------------------------
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        chatLog.text += "\nUm jogador entrou na sala Uggo! O NickName dele é:" + newPlayer.NickName;

    }

    //------------------------------------------------------------------------------------------

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        chatLog.text += "\nUm jogador saiu na sala Uggo! O NickName dele era:" + otherPlayer.NickName;

    }

    public override void OnErrorInfo(ErrorInfo errorInfo)
    {
        chatLog.text += "\nAconteceu um erro! " + errorInfo.Info;
    }
}