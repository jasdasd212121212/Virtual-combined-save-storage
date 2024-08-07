using UnityEngine;

public class ReadMonoTest : MonoTestBase
{
    [SerializeField] private string _name;

    protected override void OnTestRunned()
    {
        Debug.Log(VirtualStorageFacade.ReadFile(_name));
    }
}