using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class stop : MonoBehaviour
{



    public static GameObject tela;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void opcoes()
    {
        SceneManager.LoadScene("opcoes");

    }

    public void Voltar()
    {
        Destroy(tela);

    }
}
