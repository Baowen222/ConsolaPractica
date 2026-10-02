using UnityEngine;
using UnityEngine.SceneManagement;

public class FinJuego : MonoBehaviour
{
    public void Reiniciar()
    {
        Debug.Log("Se ha reiniciado la partida");
        SceneManager.LoadScene("Juego");
    }

    public void VolverMenu()
    {
        Debug.Log("Se ha vuelto al menu principal");
        SceneManager.LoadScene("Menu");
    }
}