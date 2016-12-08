using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{

    public Text text;

    private enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom };
    private States myState;

    // Use this for initialization
    void Start()
    {
        myState = States.cell;
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.cell)
        {
            state_cell();
        }
        else if (myState == States.sheets_0)
        {
            state_sheets_0();
        }
        else if (myState == States.lock_0)
        {

        }
    }

    #region states handler methods
    void state_cell()
    {
        text.text = "Text messaging, or texting, is the act of composing and sending electronic messages, " +
                    "typically consisting of alphabetic and numeric characters, between two or more users of mobile phones, " +
                    "fixed devices (e.g., desktop computers) or portable devices (e.g., tablet computers or smartphones). \n\n" +
                    "Press S to view, M to view, L to view";

        if (Input.GetKey(KeyCode.S))
        {
            myState = States.sheets_0;
        }

    }

    void state_sheets_0()
    {
        text.text = "Text messaging, or texting, is the act of composing and sending electronic messages,\n\n " +

                    "Press S to view, M to view, L to view";

        if (Input.GetKey(KeyCode.R))
        {
            myState = States.cell;
        }

    }
    #endregion
}
