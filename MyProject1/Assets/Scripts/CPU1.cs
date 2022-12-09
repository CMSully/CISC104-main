using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPU1 : MonoBehaviour
{
    public GameRunner isturnCPU1;
    public GameRunner hitchanceCPU1;
    public GameRunner choiceCPU1;

    // Update is called once per frame
    void Update()
    {
        if(GameRunner.isturnCPU1 == true)
        {
            GameRunner.isturnCPU1 = false;
            //Decides who to attack
            //1 is P1, 2 is P3, 3 is both
            GameRunner.choiceCPU1 = Random.Range(1, 4);
        }
    }
}
