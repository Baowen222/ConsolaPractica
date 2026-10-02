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
            panelVictoria.SetActive(true);

            EventSystem.current.SetSelectedGameObject(botonReiniciar);
        }
    }
}