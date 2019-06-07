using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{

    public GameObject PP;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {   
            Pausar();
        }
    }
    public void Pausar()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;

           // Instantiate(stop.tela, PP.position, Quaternion.identity);


        }
        else
        {
            Time.timeScale = 0;
        }
    }
}

