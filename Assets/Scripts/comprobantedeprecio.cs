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
        DineroDisponible = Random.Range(5, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
