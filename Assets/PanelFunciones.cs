using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelFunciones : MonoBehaviour
{

    public void Reintentar()
    {
        gameObject.SetActive(false);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Salir()
    {
        SceneManager.LoadScene("SelectorJuegos");
    }
}
