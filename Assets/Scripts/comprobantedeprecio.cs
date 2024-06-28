using UnityEngine.UI;
using UnityEngine;

public class comprobantedeprecio : MonoBehaviour
{
    int alimentos;
    public int DineroDisponible;
    public Text DineroTexto;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        Random random = new Random();

        DineroDisponible = Random.Range(1, 1000);

=======
        DineroDisponible = Random.Range(5, 100);
>>>>>>> 025f31f985deeb2e934462d505b90b3c0721f7e6
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD

    }    void AlcanzaYSobra()
    {
        if (alimentos < DineroDisponible)
        {
            
        }
=======
        
>>>>>>> 025f31f985deeb2e934462d505b90b3c0721f7e6
    }
}
