using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PauseMenu_editTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Edit_tests()
        {
            Assert.True(PauseMenu.GameIsPaused == false);
            Assert.True( Time.timeScale == 1f);
            //pauseMenu.Pause();
            //pauseMenu.Resume();
        }

    }
}
