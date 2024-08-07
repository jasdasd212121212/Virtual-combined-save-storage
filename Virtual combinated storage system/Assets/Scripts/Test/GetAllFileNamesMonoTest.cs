using UnityEngine;

public class GetAllFileNamesMonoTest : MonoTestBase
{
    protected override void OnTestRunned()
    {
        string[] fileNames = VirtualStorageFacade.GetAllFileNames();

        foreach (string fileName in fileNames)
        {
            Debug.Log(fileName);
        }
    }
}