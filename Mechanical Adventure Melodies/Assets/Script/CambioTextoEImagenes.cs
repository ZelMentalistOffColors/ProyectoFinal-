using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioTextoEImagenes : MonoBehaviour
{
    public GameObject[] textosEImagenes;
    public int indice;
    public GameObject elementoDisponible;

    // Variable para controlar la disponibilidad del elemento
    private bool elementoDisponibleBool = true;

    private void Update()
    {
        // Verificar disponibilidad del elemento
        VerificarDisponibilidadElemento();
    }

    // Funci�n para verificar la disponibilidad del elemento actual
    private void VerificarDisponibilidadElemento()
    {
        // Activar o desactivar el elemento disponible seg�n la disponibilidad
        elementoDisponible.SetActive(elementoDisponibleBool);
    }

    // Funci�n para mostrar el siguiente elemento
    public void Siguiente()
    {
        // Incrementar el �ndice y mostrar el elemento correspondiente
        indice = (indice + 1) % textosEImagenes.Length;
        MostrarElemento(indice);
    }

    // Funci�n para mostrar el elemento anterior
    public void Anterior()
    {
        // Decrementar el �ndice y mostrar el elemento correspondiente
        indice = (indice - 1 + textosEImagenes.Length) % textosEImagenes.Length;
        MostrarElemento(indice);
    }

    // Funci�n para mostrar un elemento espec�fico seg�n el �ndice
    private void MostrarElemento(int indexToShow)
    {
        // Mostrar solo el elemento correspondiente y ocultar los dem�s
        for (int i = 0; i < textosEImagenes.Length; i++)
        {
            textosEImagenes[i].SetActive(i == indexToShow);
        }
    }
}
