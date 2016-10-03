using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputManager {
    Dictionary<string, KeyCode> table;
    int controller;

    public InputManager(int controller)
    {
        this.controller = controller;
        table = new Dictionary<string, KeyCode>();
        table.Add("x", KeyCode.Joystick1Button1+(20*controller));
        table.Add("square", KeyCode.Joystick1Button0 + (20 * controller));
        table.Add("circle", KeyCode.Joystick1Button2 + (20 * controller));
        table.Add("triangle", KeyCode.Joystick1Button3 + (20 * controller));
        table.Add("R1", KeyCode.Joystick1Button5 + (20 * controller));
        table.Add("L1", KeyCode.Joystick1Button4 + (20 * controller));
        table.Add("L2", KeyCode.Joystick1Button6 + (20 * controller));
        table.Add("R2", KeyCode.Joystick1Button7 + (20 * controller));
        table.Add("share", KeyCode.Joystick1Button8 + (20 * controller));
        table.Add("options", KeyCode.Joystick1Button9 + (20 * controller));
        table.Add("L3", KeyCode.Joystick1Button10 + (20 * controller));
        table.Add("R3", KeyCode.Joystick1Button11 + (20 * controller));
    }

    public Vector2 LeftStick()
    {
        Vector2 vec = new Vector2();
        vec = new Vector2(Input.GetAxis("PS4 LSH" + controller), Input.GetAxis("PS4 LSV" + controller));
        return vec;
    }
    public Vector2 RightStick()
    {
        Vector2 vec = new Vector2();
        vec = new Vector2(Input.GetAxis("PS4 RSH" + controller), Input.GetAxis("PS4 RSV" + controller));
        return vec;
    }

    public bool OnDown(string button)
    {
        return Input.GetKeyDown(table[button]);
    }

    public bool OnUp(string button)
    {
        return Input.GetKeyUp(table[button]);
    }

    public bool On(string button)
    {
        return Input.GetKey(table[button]);
    }
}
