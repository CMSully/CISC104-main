using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public GameRunner isturnPlayer1;
    public GameRunner hitchancePlayer1;
    public GameRunner choicePlayer1;

    // Update is called once per frame
    void Update()
    {
        if (GameRunner.isturnPlayer1 == true)
        {
            //User input checker(either 2 or 3)
            if (Input.GetKey(KeyCode.Alpha2))
            {
                GameRunner.isturnPlayer1 = false;
                //Attacks CPU1 (Player 2)
                GameRunner.choicePlayer1 = 1;
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                GameRunner.isturnPlayer1 = false;
                //Attacks CPU2 (Player 3)
                GameRunner.choicePlayer1 = 2;
            }
        }
    }
}
