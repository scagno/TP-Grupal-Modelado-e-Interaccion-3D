using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerAlimentos : MonoBehaviour
{
    public GameObject[] Alimentos;
    int random = 0;
    // Start is called before the first frame update
    void Start()
    {
        ResetearAlimentos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ResetearAlimentos()
    {
        //desactivar todos los elementos del array 
        //activar solo el primer elemento
        DesactivarTodoslosElementos();
        ActivarRandom();
    }

    void ActivarRandom()
    {
        Alimentos[Random.Range(0, Alimentos.Length)].SetActive(true);
    }

    void DesactivarTodoslosElementos()
    {
        for (int i = 0; i < Alimentos.Length; i++)
        {
            Alimentos[i].SetActive(false);
        }
    }
}
