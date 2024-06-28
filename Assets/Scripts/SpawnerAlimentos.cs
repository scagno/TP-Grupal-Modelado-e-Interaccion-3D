using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerAlimentos : MonoBehaviour
{
    public GameObject[] Alimentos;
    public Producto alimento1;
    public Producto alimento2;
    public Vector3 position1;
    public Vector3 position2;
    public Text text1;
    public Text text2;

    void Start()
    {
        SpawnAlimentos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnAlimentos()
    {
        alimento1 = Instantiate(GetRandomAlimento(), position1, Quaternion.identity).GetComponent<Producto>();
        alimento2 = Instantiate(GetRandomAlimento(), position2, Quaternion.identity).GetComponent<Producto>();
        text1.text = "$" + alimento1.precio.ToString();
        text2.text = "$" + alimento2.precio.ToString();
    }

    public GameObject GetRandomAlimento()
    {
        return Alimentos[Random.Range(0, Alimentos.Length)];
    }
}
