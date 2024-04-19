using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton instancia;
    public AudioSource audioSource;

    public string nombre;
    public bool Audio;
    public float volumen;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();

    }

    private void Update()

    {
        audioSource.volume = volumen;
    }
}
