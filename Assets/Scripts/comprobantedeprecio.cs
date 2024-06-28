using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class comprobantedeprecio : MonoBehaviour
{
    public Text txtDinero;
    private int DineroDisponible;
    public SpawnerAlimentos alimentos;
    public GameObject panelGanar;
    public GameObject panelPerder;

    void Start()
    {
        DineroDisponible = Random.Range(1, 50);
        txtDinero.text = "$" + DineroDisponible.ToString();
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

        if (suma < DineroDisponible)
        {
            MostrarPanelGanar();
            return;
        }
        MostrarPanelPerder();
    }

    public void BtnNoAlcanza()
    {
        int suma = alimentos.alimento1.precio + alimentos.alimento2.precio;

        if (suma > DineroDisponible)
        {
            MostrarPanelGanar();
            return;
        }
        MostrarPanelPerder();
    }

    private void MostrarPanelGanar()
    {
        panelGanar.SetActive(true);
    }

    private void MostrarPanelPerder()
    {
        panelPerder.SetActive(true);
    }
}
