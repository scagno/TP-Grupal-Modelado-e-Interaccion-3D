using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprobantedeprecio : MonoBehaviour
{
    int alimentos;
    public int DineroDisponible;
    // Start is called before the first frame update
    void Start()
    {
        Random random = new Random();

        DineroDisponible = Random.Range(1, 1000);

    }

    // Update is called once per frame
    void Update()
    {

    }    void AlcanzaYSobra()
    {
        if (alimentos < DineroDisponible)
        {
            
        }
    }
}
