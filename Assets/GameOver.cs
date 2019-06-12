using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void IrParaOMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void JogarDenovo()
    {
        SceneManager.LoadScene("Persona PI");
    }

}