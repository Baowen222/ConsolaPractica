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

    void Update()
    {
        movimiento = Vector2.zero;

        // Teclado
        if (Keyboard.current != null)
        {
            if (Keyboard.current.wKey.isPressed)
                movimiento.y += 1;

            if (Keyboard.current.sKey.isPressed)
                movimiento.y -= 1;

            if (Keyboard.current.aKey.isPressed)
                movimiento.x -= 1;

            if (Keyboard.current.dKey.isPressed)
                movimiento.x += 1;
        }

        // Mando
        if (Gamepad.current != null)
        {
            movimiento = Gamepad.current.leftStick.ReadValue();

            if (Gamepad.current.dpad.ReadValue() != Vector2.zero)
            {
                movimiento = Gamepad.current.dpad.ReadValue();
            }
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movimiento.normalized * velocidad;
    }
}