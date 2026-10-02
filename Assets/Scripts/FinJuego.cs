using UnityEngine;
using UnityEngine.SceneManagement;

public class FinJuego : MonoBehaviour
{
    public void Reiniciar()
    {
        SceneManager.LoadScene("Juego");
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}