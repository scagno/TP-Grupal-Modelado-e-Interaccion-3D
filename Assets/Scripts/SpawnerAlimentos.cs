using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerAlimentos : MonoBehaviour
{
    public Vector3 posicion1;
    public Vector3 posicion2;
    public Text text1;
    public Text text2;
    public GameObject[] Alimentos;

    void Start()
    {
        SpawnearAlimentos();
    }

    void SpawnearAlimentos()
    {
        GameObject alimento1 = GetRandomAlimento();
        GameObject alimento2 = GetRandomAlimento();
        text1.text = "$" + alimento1.GetComponent<Producto>().precio.ToString();
        text2.text = "$" + alimento2.GetComponent<Producto>().precio.ToString();
        Instantiate(alimento1, posicion1, Quaternion.identity);
        Instantiate(alimento2, posicion2, Quaternion.identity);
    }

    GameObject GetRandomAlimento()
    {
        return Alimentos[Random.Range(0, Alimentos.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
