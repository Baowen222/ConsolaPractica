
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinJuego : MonoBehaviour
{
    public void Reiniciar()
    {
        // Devuelve el tiempo a la normalidad
        Time.timeScale = 1f;

        Debug.Log("Se ha reiniciado la partida");
        SceneManager.LoadScene("Juego");
    }

    public void VolverMenu()
    {
        // Devuelve el tiempo a la normalidad
        Time.timeScale = 1f;

        Debug.Log("Se ha vuelto al menu principal");
        SceneManager.LoadScene("Menu");
    }
}
