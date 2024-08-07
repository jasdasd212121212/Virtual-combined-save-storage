using UnityEngine;

public class VirtualFileStorageEntryPoint
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Construct()
    {
        IStorageSerializerStrategy storageSerializerStrategy = new LocalFileSaver();

        VirtualStorageFacade.Initialize(storageSerializerStrategy);
    }
}