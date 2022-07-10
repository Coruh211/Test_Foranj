using UnityEngine;

public class JoystickInput : Singleton<JoystickInput>
{
    [SerializeField] private Joystick joystick;

    public Joystick Joystick => joystick;
    public Vector2 Direction => joystick.Direction;
}