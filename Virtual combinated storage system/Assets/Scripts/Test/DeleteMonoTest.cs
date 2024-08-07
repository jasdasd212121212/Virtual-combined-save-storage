using UnityEngine;

public class DeleteMonoTest : MonoTestBase
{
    [SerializeField] private string _name;

    protected override void OnTestRunned()
    {
        VirtualStorageFacade.DeleteFile(_name);
    }
}