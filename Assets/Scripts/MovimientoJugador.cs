using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;

    private Rigidbody2D rb;
    private Vector2 movimiento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue valor)
    {
        movimiento = valor.Get<Vector2>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movimiento.normalized * velocidad;
    }
}