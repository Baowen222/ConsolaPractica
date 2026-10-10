using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MenuPausa : MonoBehaviour
{
    public GameObject panelPausa;
    public GameObject botonContinuar;

    private bool pausado = false;

    void Update()
    {
        // Detecta el botón Start del mando
        if (Gamepad.current != null &&
            Gamepad.current.startButton.wasPressedThisFrame)
        {
            if (pausado)
                Continuar();
            else
                Pausar();
        }
    }

    public void Pausar()
    {
        pausado = true;
        Time.timeScale = 0f;
        panelPausa.SetActive(true);

        // Selecciona Continuar para usar el mando
        EventSystem.current.SetSelectedGameObject(botonContinuar);
    }

    public void Continuar()
    {
        pausado = false;
        Time.timeScale = 1f;
        panelPausa.SetActive(false);
    }
}