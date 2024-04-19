using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UsuarioRanking : MonoBehaviour
{
    public TextMeshProUGUI textoNombreUsuario;
    void Start()
    {
        if (Manager.instance != null)
        {

            textoNombreUsuario.text = Manager.instance.nombre_usuarioActual;


        }
    }

   
}
