using UnityEngine;
using UnityEngine.EventSystems;

public class Meta : MonoBehaviour
{
    public GameObject panelVictoria;
    public GameObject botonReiniciar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("El jugador ha llegado a la meta");
            panelVictoria.SetActive(true);

            EventSystem.current.SetSelectedGameObject(botonReiniciar);
        }
    }
}