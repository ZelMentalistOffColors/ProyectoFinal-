using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorBotones : MonoBehaviour
{
    public CambioTextoEImagenes cambioTextoEImagenes; // Referencia al script CambioTextoEImagenes
    public Button botonSiguiente;
    public Button botonAnterior;

    private void Start()
    {
        // Obtener las referencias a los botones
        botonSiguiente.onClick.AddListener(OnSiguienteClick);
        botonAnterior.onClick.AddListener(OnAnteriorClick);
    }

    // Método que se ejecutará cuando se haga clic en el botón de siguiente
    private void OnSiguienteClick()
    {
        cambioTextoEImagenes.Siguiente();
    }

    // Método que se ejecutará cuando se haga clic en el botón de anterior
    private void OnAnteriorClick()
    {
        cambioTextoEImagenes.Anterior();
    }
}
