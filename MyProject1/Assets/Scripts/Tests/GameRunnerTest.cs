using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayersTest
{

    public CPU1 isturnCPU1;
    public CPU1 hitchanceCPU1;
    public CPU1 choiceCPU1;

    // A Test behaves as an ordinary method
    [Test]
    public void NewTestScript1SimplePasses()
    {
        // Use the Assert class to test conditions
        Assert.AreEqual(1, 1);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewTestScript1WithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
