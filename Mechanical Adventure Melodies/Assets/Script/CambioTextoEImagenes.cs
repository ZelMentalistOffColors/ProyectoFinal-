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

    // Función para verificar la disponibilidad del elemento actual
    private void VerificarDisponibilidadElemento()
    {
        // Activar o desactivar el elemento disponible según la disponibilidad
        elementoDisponible.SetActive(elementoDisponibleBool);
    }

    // Función para mostrar el siguiente elemento
    public void Siguiente()
    {
        // Incrementar el índice y mostrar el elemento correspondiente
        indice = (indice + 1) % textosEImagenes.Length;
        MostrarElemento(indice);
    }

    // Función para mostrar el elemento anterior
    public void Anterior()
    {
        // Decrementar el índice y mostrar el elemento correspondiente
        indice = (indice - 1 + textosEImagenes.Length) % textosEImagenes.Length;
        MostrarElemento(indice);
    }

    // Función para mostrar un elemento específico según el índice
    private void MostrarElemento(int indexToShow)
    {
        // Mostrar solo el elemento correspondiente y ocultar los demás
        for (int i = 0; i < textosEImagenes.Length; i++)
        {
            textosEImagenes[i].SetActive(i == indexToShow);
        }
    }
}
