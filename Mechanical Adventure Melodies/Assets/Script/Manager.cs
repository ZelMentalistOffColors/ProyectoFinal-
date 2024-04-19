using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance;

    public string nombre_usuarioActual;
    public string correo_usuarioActual;
    public string contraseña_usuarioActual;
    public int nivel_usuarioActual;
    public int rubis_usuarioActual;
    public int esmeraldas_usuarioActual;
    public string titulo_usuarioActual;
    public int ranking_usuarioActual;
   

    public List<string> usuarios = new List<string>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        usuarios.Add("Rodrigo");

       
        if (usuarios.Count > 0)
        {
            nombre_usuarioActual = usuarios[0];

            nivel_usuarioActual = 1;

            titulo_usuarioActual = "Heroe Principiante";

            rubis_usuarioActual = 10000;

            esmeraldas_usuarioActual = 200;

            ranking_usuarioActual = 0;


        }
    }

}