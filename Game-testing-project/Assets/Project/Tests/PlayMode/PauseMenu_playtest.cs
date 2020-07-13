using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class PauseMenu_playtest
    {
        [UnityTest]
        public IEnumerator PauseGame()
        {
            var GameObject = new GameObject();
            PauseMenu pauseMenu = new PauseMenu();
            
            yield return new WaitForSeconds(2.0f);
            //Assert.True(PauseMenu.GameIsPaused==false);

        }
        [UnityTest]
        public IEnumerator ContinueGame()
        {
            
            PauseMenu pauseMenu = new PauseMenu();
            Debug.Log(PauseMenu.GameIsPaused);
            //pauseMenu.Pause();
            //pauseMenu.Resume();
            yield return new WaitForSeconds(2.0f);
            //Assert.True( Time.timeScale == 1f );
            //Assert.True( !PauseMenu.GameIsPaused );
            //Assert.True(pauseMenu.pauseMenuUI.activeSelf == false);
            //Debug.Log("test");
            
          
        }
        [UnityTest]
        public IEnumerator LoadMainMenu()
        {
            var GameObject = new GameObject();
            PauseMenu pauseMenu = new PauseMenu();
            pauseMenu.LoadMenu();
            yield return null;
            string expected = "Menu1";
            string actual = SceneManager.GetActiveScene().name;
            Assert.AreEqual( expected, actual);
        }
        [UnityTest]
        public IEnumerator QuitGame()
        {
            var GameObject = new GameObject();
            PauseMenu pauseMenu = new PauseMenu();
            pauseMenu.QuitGame();
            yield return new WaitForSeconds(2.0f);
            Assert.True(pauseMenu==null);
        }
        
    }
}
