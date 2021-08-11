using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuLobby : MonoBehaviour
{
    [SerializeField] private Text _listaDeJogadores;
    [SerializeField] private Button _comecarjogo;

    public void AtualizaLista()
    {
        _listaDeJogadores.text = GestorDeRede.Instancia.ObterListaDejogadores();
        _comecarjogo.interactable = GestorDeRede.Instancia.DonoDaSala();
    }
}
