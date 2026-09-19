using UnityEngine;
using UnityEngine.InputSystem;

public class Moverse : MonoBehaviour
{
    public float velocidad = 5f;
    void Update()
    {
        if (Keyboard.current == null) return;
        Vector2 mov = Vector2.zero;
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) mov.y = 1;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) mov.y = -1;
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) mov.x = -1;
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) mov.x = 1;
        transform.Translate(mov * velocidad * Time.deltaTime);
    }
}