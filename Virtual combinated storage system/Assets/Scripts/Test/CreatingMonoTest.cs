using UnityEngine;

public class CreatingMonoTest : MonoTestBase
{
    [SerializeField] private string _name;
    [SerializeField][TextArea()] private string _text;

    protected override void OnTestRunned()
    {
        VirtualStorageFacade.CreateFile(_name, _text);
    }
}