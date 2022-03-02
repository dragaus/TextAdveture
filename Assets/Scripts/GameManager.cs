using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string[] palabrasGuardadas;
    [SerializeField] private string[] preguntas;
    [SerializeField] private string historia;

    [SerializeField] TextMeshProUGUI textoPreguntas;
    [SerializeField] TextMeshProUGUI textoHistoria;
    [SerializeField] TMP_InputField inputRespuesta;
    [SerializeField] GameObject botonRespuesta;
    [SerializeField] GameObject botonReinicio;

    int indicePregunta = 0;

    // Start is called before the first frame update
    void Start()
    {
        textoPreguntas.text = preguntas[indicePregunta];

        palabrasGuardadas = new string[preguntas.Length];
        botonReinicio.SetActive(false);
    }

    public void GuardarRespuesta()
    {
        palabrasGuardadas[indicePregunta] = inputRespuesta.text;
        inputRespuesta.text = "";
        indicePregunta++;

        if (indicePregunta >= preguntas.Length)
        {
            MostrarHistoria();
        }
        else
        { 
            textoPreguntas.text = preguntas[indicePregunta];
        }

    }

    void MostrarHistoria()
    {
        //TODO Mostrar un nuevo textmesh pro que tenga toda la historia
        textoHistoria.gameObject.SetActive(true);
        textoHistoria.text = string.Format(historia, palabrasGuardadas);
        botonReinicio.SetActive(true);

        //TODO ocultar los elementos que no se utilizan
        textoPreguntas.gameObject.SetActive(false);
        botonRespuesta.SetActive(false);
        inputRespuesta.gameObject.SetActive(false);
    }

    public void ReiniciarJuego()
    {
        // Esta es la forma de reiniciar todo
        //indicePregunta = 0;
        //palabrasGuardadas = new string[preguntas.Length];

        //textoPreguntas.text = preguntas[indicePregunta];

        //textoPreguntas.gameObject.SetActive(true);
        //botonRespuesta.SetActive(true);
        //inputRespuesta.gameObject.SetActive(true);

        //textoHistoria.gameObject.SetActive(false);
        //botonReinicio.SetActive(false);

        // Recargar la escena como estaba al principio
        int indexEscena = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexEscena);
    }
}
