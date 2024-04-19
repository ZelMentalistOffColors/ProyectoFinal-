using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class MostrarNombreUsuario : MonoBehaviour
{
    public TextMeshProUGUI textoNombreUsuario;
    public TextMeshProUGUI textoNivelUsuario;
    public TextMeshProUGUI textoTituloUsuario;
    public TextMeshProUGUI textoRubisUsuario;
    public TextMeshProUGUI textoEsmeraldasoUsuario;
    public TextMeshProUGUI textoRanking;




    private void Start()
    {
        // Verificar si el Manager existe y tiene un nombre de usuario actual
        if (Manager.instance != null && !string.IsNullOrEmpty(Manager.instance.nombre_usuarioActual))
        {
            // Asignar el nombre de usuario al TextMeshPro
            textoNombreUsuario.text = " " + Manager.instance.nombre_usuarioActual;
            textoNivelUsuario.text = "Nivel    " + Manager.instance.nivel_usuarioActual;
            textoRubisUsuario.text = " " + Manager.instance.rubis_usuarioActual;
            textoEsmeraldasoUsuario.text = " " + Manager.instance.esmeraldas_usuarioActual;
            textoTituloUsuario.text = " " + Manager.instance.titulo_usuarioActual;
            textoRanking.text = "Ranking   " + Manager.instance.ranking_usuarioActual;

        }
        else
        {
            
            textoNombreUsuario.text = "No hay nombre de usuario disponible";
        }
    }
}
