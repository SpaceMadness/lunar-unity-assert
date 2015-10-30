using UnityEngine;
using System.Collections;

public class ButtonHandler : MonoBehaviour
{
    private bool shouldFailAssertInLoop;

    void Update()
    {
        assert.IsFalse(shouldFailAssertInLoop);
    }

    #region Button Handlers

    public void OnSingleAssertClick()
    {
        assert.Fail("Failed test assert");
    }

    public void OnLoopAssertClick()
    {
        shouldFailAssertInLoop = true;
    }

    #endregion
}
