using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    //
    public string playGameLevel;

    //Starts the game
    public void PlayGame()
    {
        //loads the levels of the game
        Application.LoadLevel(playGameLevel);
    }

    //Quits the game from the press of a button
    public void QuitGame()
    {
        Application.Quit();
    }
}
