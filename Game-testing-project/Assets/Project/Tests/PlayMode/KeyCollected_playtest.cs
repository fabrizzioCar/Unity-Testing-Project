using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class KeyCollected_playtest
    {

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator KeyCollected_playtestWithEnumeratorPasses()
        {
            var gameObject = new GameObject();
            //var keycoll = GameObject.Find("key");
            var keycoll = new KeyCollected();
            keycoll.DissapearKey();
            //KeyCollected keycoll= new KeyCollected();

            //Compoment key=GameObject.GetComponent("key");
            //Debug.Log("?");
            //keycoll.DissapearKey();
            //yield return new WaitForSeconds(2f);
            yield return null;
            //Assert.True(keycoll.GetComponent<SpriteRenderer>().enabled==false);
        }
    }
}
