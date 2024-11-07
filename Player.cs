using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    string playerName;
    int health;
    static int playerCount = 0;
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }
    public void Heal(int amount)
    {
        health += amount;
        if (health > 100)
        {
            health = 100;
        }
        Debug.Log("Health = " + health);
    }
    public void Heal(bool fullRestore)
    {
        if (fullRestore == true)
        {
            health = 100;
            Debug.Log("Full Health");
        }

    }
    public static void ShowPlayerCount()
    {
        Debug.Log("Number Of Player = " + playerCount);
    }
}
