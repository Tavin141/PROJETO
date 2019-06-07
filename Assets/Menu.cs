using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Persona PI");

    }

    public void Opções()
    {
        SceneManager.LoadScene("Opcoes");
    }

    public void Sair()
    {
        Application.Quit();

    }

    public void Creditos()
    {
        SceneManager.LoadScene("creditos");

    }


}
