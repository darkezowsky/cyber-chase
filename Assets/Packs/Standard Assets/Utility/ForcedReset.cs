using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Dodano do u¿ycia UI.Image
using UnityStandardAssets.CrossPlatformInput;

public class ForcedReset : MonoBehaviour
{
    private Image guiImage; // Zmienna do przechowywania referencji do Image

    private void Awake()
    {
        guiImage = GetComponent<Image>(); // Uzyskujemy komponent Image
    }

    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
