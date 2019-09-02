using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public float RestartDelay = 1f;
    bool gameHasEnded = false;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", RestartDelay);
        }
    }
        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    
}
