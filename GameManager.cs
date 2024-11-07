using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player Sabaa = new Player();
        Player Suaad = new Player();
        Sabaa.InitializePlayer("Sabaa", 30);
        Suaad.InitializePlayer("Suaad", 100);
        Sabaa.Heal(5);
        Suaad.Heal(true);

        Player.ShowPlayerCount();
    }

}
