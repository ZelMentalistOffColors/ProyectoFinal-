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

    // M�todo que se ejecutar� cuando se haga clic en el bot�n de siguiente
    private void OnSiguienteClick()
    {
        cambioTextoEImagenes.Siguiente();
    }

    // M�todo que se ejecutar� cuando se haga clic en el bot�n de anterior
    private void OnAnteriorClick()
    {
        cambioTextoEImagenes.Anterior();
    }
}
