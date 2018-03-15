using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GoneHome
{
    public class GameManager : MonoBehaviour
    {
        // Switches to next level when called
        public void NextLevel()
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }

        //Restarts elements in the level (without destroying)
        public void RestartLevel()
        {
            // Grabe all FollowEnemy game objects
            FollowEnemy[] followEnemeies = FindObjectsOfType<FollowEnemy>();
            // Loop through each one
            foreach (var enemy in followEnemeies)
            {
                // Reset each Enemy
                enemy.Reset();
            }
            //TASK: Reset all PatrolEnemeies
            // Grabe all PatrolEnemy game objects
            PatrolEnemy[] PatrolEnemeies = FindObjectsOfType<PatrolEnemy>();
            // Loop through each one
            foreach (var enemy in PatrolEnemeies)
            {
                // Reset each Enemy
                enemy.Reset();
            }
            //Get the player from the scene
            Player player = FindObjectOfType<Player>();
            //Reset the player
            player.Reset();
        }
    }
}