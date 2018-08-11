using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public enum ControllerButton
    {
        JUMP,
        ACTION
    }

    public float GetHorizontalAxis(int player)
    {
        return 0;
    }

    public bool GetButton(int player, ControllerButton button)
    {
        return false;
    }
}
