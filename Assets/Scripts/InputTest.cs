using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    [SerializeField] private KeyCode keySkill_Q = KeyCode.A;

    public BirdControl birdControl;


    private string giDay = "bka bla ";
    void Update()
    {
        //InputMouse();
        //InputKey();
        InputAxis();
    }
    protected void InputAxis()
    {
        //Input.GetAxis("Horizontal"); //-1..0..1
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        birdControl.MovePos(new Vector3(horizontalAxis, verticalAxis, 0));
    }
    void InputMouse()
    {

        //0, 1, 
        bool startClick = Input.GetMouseButtonDown(0);
        bool holdClick = Input.GetMouseButton(0);
        bool releaseClick = Input.GetMouseButtonUp(0);

        if (startClick) Debug.Log("Bắt đầu click chuột");
        if (holdClick) Debug.Log("Giữ click chuột");
        if (releaseClick) Debug.Log("Thả click chuột");
    }
    protected void InputKey()
    {
        bool startPressKey = Input.GetKeyDown(keySkill_Q);
        bool holdKey = Input.GetKey(keySkill_Q);
        bool realesKey = Input.GetKeyUp(keySkill_Q);
        if (startPressKey) Debug.Log($"Bắt đầu ấn phím {keySkill_Q.ToString()}");
        if (holdKey) Debug.Log($"Giữ phím {keySkill_Q.ToString()}");
        if (realesKey) Debug.Log($"Thả phím {keySkill_Q.ToString()}");
    }
}
