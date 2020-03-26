using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Properties
    public static int score;        // The number of coins collected. 
                                    // NOTE the 'static' keyword here. This means it can be accessed from ANY script by calling GameManager.score (Eg see Coin script)
                                    // NOTE: 'static' properties do NOT show in the Inspector.

    public int targetScore = 10;    // The number of coins to collect.

    // Methods
    private void Update()
    {
        // Check the number of coins that have been collected.
        if (GameManager.score == this.targetScore)
        {
            // Output that the number of target coins have been collected.
            Debug.Log("Player has collected " + this.targetScore + " coins!");

            // Deactivate this GameManager component so that it stops checking the score each Update().
            this.gameObject.SetActive(false);
        }
    }
}
