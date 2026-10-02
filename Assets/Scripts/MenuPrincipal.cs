using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Jugar()
    {
        Debug.Log("Se ha pulsado el boton Jugar");
        SceneManager.LoadScene("Juego");
    }

    public void Salir()
    {
        Debug.Log("Se ha pulsado el boton Salir");
        Application.Quit();
    }
}