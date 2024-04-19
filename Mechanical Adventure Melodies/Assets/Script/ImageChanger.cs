using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    public Image imageToUpdate;
    public Image imageToUpdate1;
    public Image imageToUpdate2;


    public void ChangeImage()
    {
        // Abrir la galería del dispositivo
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            if (path != null)
            {
                // Cargar la imagen seleccionada y actualizar el sprite de la imagen
                Texture2D texture = NativeGallery.LoadImageAtPath(path);
                if (texture != null)
                {
                    Sprite newSprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.one * 0.5f);
                    imageToUpdate.sprite = newSprite;

                    imageToUpdate1.sprite = newSprite;
                    imageToUpdate2.sprite = newSprite;
                }
            }
        }, "Seleccionar imagen", "image/*");

        Debug.Log("Permission result: " + permission);
    }
}
