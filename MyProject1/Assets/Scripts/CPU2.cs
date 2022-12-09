using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPU2 : MonoBehaviour
{
    public GameRunner isturnCPU2;
    public GameRunner hitchanceCPU2;
    public GameRunner choiceCPU2;
    public GameRunner hitchanceCPU1;
    public GameRunner hitchancePlayer1;
    public GameRunner inputtime;
    public GameRunner targetPlayer3;

    // Update is called once per frame
    void Update()
    {
        if (GameRunner.isturnCPU2 == true)
        { 
            GameRunner.isturnCPU2 = false;
            if (GameRunner.choiceCPU2 == 1)
            {
                GameRunner.targetPlayer3 = "1";
                GameRunner.choiceCPU2 = 0;
                GameRunner.hitchancePlayer1 -= 10;
            }
            else if (GameRunner.choiceCPU2 == 2)
            {
                GameRunner.targetPlayer3 = "2";
                GameRunner.choiceCPU2 = 0;
                GameRunner.hitchanceCPU1 -= 10;
            }
            else if (GameRunner.choiceCPU2 == 3)
            {
                GameRunner.targetPlayer3 = "1 and 2";
                GameRunner.choiceCPU2 = 0;
                GameRunner.hitchanceCPU1 -= 10;
                GameRunner.hitchancePlayer1 -= 10;
            }
            else
            {
                GameRunner.targetPlayer3 = "N/A";
                GameRunner.choiceCPU2 = 0;
            }
            //Sets the game to be run
            GameRunner.inputtime = true;
        }
    }
}
