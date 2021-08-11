using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour
{
    public bool p1confirm, p2confirm, p3confirm;

    void Start()
    {
        p1confirm = false;
        p2confirm = false;
        p3confirm = false;
    }
    void Update()
    {
        
    }
    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void instruct()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
        if (ConectarNoJogo.salaCapacity > 0)
        {
            ConectarNoJogo.salaCapacity -= 1;
        }
    }
    public void conect()
    {
        SceneManager.LoadScene("Conect");
        if (ConectarNoJogo.salaCapacity <= 2)
        {
            ConectarNoJogo.salaCapacity += 1;
        }
        else
        {
            print("Sala Cheia");
        }
    }
    public void game1()
    {
        SceneManager.LoadScene("Game1ano");
    }
    public void game2()
    {
        SceneManager.LoadScene("Game2ano");
    }
    public void game3()
    {
        SceneManager.LoadScene("Game3ano");
    }
    public void gameF()
    {
        SceneManager.LoadScene("GameENEM");
    }
    public void gameEnd()
    {
        SceneManager.LoadScene("GameEnd");
    }
    public void NickEsala()
    {
        SceneManager.LoadScene("nickSala");
    }
    public void sairdoJogo()
    {
        Application.Quit();
    }
}