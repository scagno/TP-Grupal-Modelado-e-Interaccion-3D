using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprobantedeprecio : MonoBehaviour
{
    private int DineroDisponible;
    public SpawnerAlimentos alimentos; 

    void Start()
    {
        DineroDisponible = Random.Range(1, 50);

    }

    public void BtnAlcanza()
    {
        int suma = alimentos.alimento1.precio + alimentos.alimento2.precio;

        if(suma == DineroDisponible)
        {
            MostrarPanelGanar();
            return;
        }
        MostrarPanelPerder();
    }

    public void BtnAlcanzaYSobra()
    {
        int suma = alimentos.alimento1.precio + alimentos.alimento2.precio;

        if (suma >= DineroDisponible)
        {
            MostrarPanelGanar();
            return;
        }
        MostrarPanelPerder();
    }

    public void BtnNoAlcanza()
    {
        int suma = alimentos.alimento1.precio + alimentos.alimento2.precio;

        if (suma <= DineroDisponible)
        {
            MostrarPanelGanar();
            return;
        }
        MostrarPanelPerder();
    }

    private void MostrarPanelGanar()
    {

    }

    private void MostrarPanelPerder()
    {

    }
}
