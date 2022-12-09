using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRunner : MonoBehaviour
{
    //Variables for printing
    public Text Round;
    public Text P1Score;
    public Text P2Score;
    public Text P3Score;
    public Text P1Hit;
    public Text P2Hit;
    public Text P3Hit;
    public Text P1Target;
    public Text P2Target;
    public Text P3Target;
    public Text Winner;
    public Text Instructions;
    public static string targetPlayer3;
    //Variables for scoring
    public static int scorePlayer1 = 0;
    public static int scoreCPU1 = 0;
    public static int scoreCPU2 = 0;
    //Comparison number for scoring
    int hitnumber = 100;
    //Checks for time to run game
    public static bool gamerun = false;
    public static bool inputtime = false;
    //Turn counter
    public static int turn = 1;
    //Slows down update
    float timer = 0;
    bool timerReached = false;
    //Used in other scipts for players data
    public static bool isturnPlayer1 = true;
    public static int hitchancePlayer1 = 25;
    public static int choicePlayer1 = 0;
    public static bool isturnCPU1 = false;
    public static int hitchanceCPU1 = 35;
    public static int choiceCPU1 = 0;
    public static bool isturnCPU2 = false;
    public static int hitchanceCPU2 = 30;
    public static int choiceCPU2 = 0;
    
    void Start()
    {
        Round.text = (GameRunner.turn).ToString();
        Instructions.text = "Player 1: Press 2 or 3 to attack players 2 or 3";
    }

    // Update is called once per frame
    void Update()
    {
        //Gets player choice, acts on it
        if (choicePlayer1 == 1)
        {
            P1Target.text = ("2");
            choicePlayer1 = 0;
            isturnPlayer1 = false;
            hitchanceCPU1 -= 6;
            isturnCPU1 = true;
        }
        else if (choicePlayer1 == 2)
        {
            P1Target.text = ("3");
            choicePlayer1 = 0;
            isturnPlayer1 = false;
            hitchanceCPU2 -= 6;
            choiceCPU2 += 1;
            isturnCPU1 = true;
        }

        //Gets CPU1 random choice and acts on it
        if (choiceCPU1 == 1)
        {
            P2Target.text = ("1");
            choiceCPU1 = 0;
            isturnCPU1 = false;
            hitchancePlayer1 -= 8;
            isturnCPU2 = true;
        }
        else if (choiceCPU1 == 2)
        {
            P2Target.text = ("3");
            choiceCPU1 = 0;
            isturnCPU1 = false;
            hitchanceCPU2 -= 8;
            choiceCPU2 += 2;
            isturnCPU2 = true;
        }
        else if (choiceCPU1 == 3)
        {
            P2Target.text = ("1 and 3");
            choiceCPU1 = 0;
            isturnCPU1 = false;
            hitchancePlayer1 -= 4;
            hitchanceCPU2 -= 4;
            choiceCPU2 += 2;
            isturnCPU2 = true;
        }

        //User input to run the game
        if (inputtime == true)
        {
            //Prints round, hit chances, targets
            Round.text = (turn).ToString();
            P1Hit.text = (hitchancePlayer1).ToString();
            P2Hit.text = (hitchanceCPU1).ToString();
            P3Hit.text = (hitchanceCPU2).ToString();
            P3Target.text = (targetPlayer3);
            //Space to run the simulation
            Instructions.text = "Press the space key to run the game!";
            if (Input.GetKey(KeyCode.Space))
            {
                inputtime = false;
                gamerun = true;
            }
        }

        //Runs the game
        if (gamerun == true)
        {
            isturnCPU2 = false;
            isturnCPU1 = false;
            isturnPlayer1 = false;
            choicePlayer1 = 0;
            choiceCPU1 = 0;
            choiceCPU2 = 0;
            inputtime = false;
            
            if (timerReached == true)
            {
                //Resets for next round
                gamerun = false;
                timer = 0;
                timerReached = false;
                turn++;

                //Sees if a player hits 
                hitnumber = Random.Range(1, 101);
                if ((hitnumber - hitchancePlayer1) <= 0)
                {
                    scorePlayer1 += 1;
                }
                if ((hitnumber - hitchanceCPU1) <= 0)
                {
                    scoreCPU1 += 1;
                    
                }
                if ((hitnumber - hitchanceCPU2) <= 0)
                {
                    scoreCPU2 += 1;
                }

                //Prints Scores
                P1Score.text = (scorePlayer1).ToString();
                P2Score.text = (scoreCPU1).ToString();
                P3Score.text = (scoreCPU2).ToString();

                //Checks for Winner/Ties, if no winners starts next round
                if (scorePlayer1 == 5)
                {
                    if (scoreCPU1 == 5)
                    {
                        if (scoreCPU2 == 5)
                        {
                            Winner.text = ("All Players Tie!");
                            Instructions.text = "";
                        }
                    }
                    else if (scoreCPU2 == 5)
                    {
                        Winner.text = ("Players 1 and 3 Tie!");
                        Instructions.text = "";
                    }
                    else
                    {
                        Winner.text = ("Player 1 Wins!");
                        Instructions.text = "";
                    }
                }
                else if (scoreCPU1 == 5)
                {
                    if (scoreCPU2 == 5)
                    {
                        Winner.text = ("Players 2 and 3 Tie!");
                        Instructions.text = "";
                    }
                    else
                    {
                        Winner.text = ("Player 2 Wins!");
                        Instructions.text = "";
                    }
                }
                else if (scoreCPU2 == 5)
                {
                    Winner.text = ("Player 3 Wins!");
                    Instructions.text = "";
                }
                else
                {
                    Instructions.text = "Player 1: Press 2 or 3 to attack players 2 or 3";
                    isturnPlayer1 = true;
                }
                //Resets Chances / Targets and their text
                hitchancePlayer1 = 25;
                hitchanceCPU1 = 35;
                hitchanceCPU2 = 30;
                P1Hit.text = (hitchancePlayer1).ToString();
                P2Hit.text = (hitchanceCPU1).ToString();
                P3Hit.text = (hitchanceCPU2).ToString();
                targetPlayer3 = "N/A";
                P1Target.text = ("N/A");
                P2Target.text = ("N/A");
                P3Target.text = (targetPlayer3);
            }
            else
            {
                timer += Time.deltaTime;
            }
            if(timer > 0.1)
            {
                timerReached = true;
            }
        }
    }
}
