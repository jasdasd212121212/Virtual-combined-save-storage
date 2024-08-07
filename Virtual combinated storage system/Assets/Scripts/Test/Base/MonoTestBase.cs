using UnityEngine;

public abstract class MonoTestBase : MonoBehaviour
{
    [ContextMenu("Run test")]
    private void RunTest()
    {
        if (Application.isPlaying == false)
        {
            Debug.LogError("Test error -> you can run mono test ONLY AT RUNTIME !!!");
            return;
        }

        OnTestRunned();
    }

    protected abstract void OnTestRunned();
}