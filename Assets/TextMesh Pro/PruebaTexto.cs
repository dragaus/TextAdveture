using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PruebaTexto : MonoBehaviour
{
    public TextMeshProUGUI textoEditable;
    public Color colorTexto = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        textoEditable.text = "Hola me llamo paco";
        textoEditable.color = colorTexto;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
