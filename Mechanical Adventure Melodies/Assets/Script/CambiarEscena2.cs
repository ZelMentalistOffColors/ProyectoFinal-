using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambiarEscena2 : MonoBehaviour
{
    public Slider nivelVolumen;
    public TMP_InputField inputField;

    void Start()
    {

        inputField.text = Singleton.instancia.nombre;
        nivelVolumen.value = Singleton.instancia.volumen;

    }
    public void CambiarEscena_2()
    {

        StartCoroutine("CambiarDeEscena");

    }

    public void CambioVolumen()
    {
        Singleton.instancia.volumen = nivelVolumen.value;
    }

    IEnumerator CambiarDeEscena()
    {

        Singleton.instancia.nombre = inputField.text;
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(1);

    }
}
