using UnityEngine;

public class TrackingAction : MonoBehaviour
{
    public TrackableObserver Observer;
    
    private void Start()
    {
#if !UNITY_EDITOR
        Destroy(GameObject.Find("EmulatorRoom"));
#endif
        Observer.FoundEvent += FoundEvent;
        Observer.LostEvnet += LostEvent;
    }

    private void FoundEvent(Vector3 position, Quaternion rotation)
    {
        
    }

    private void LostEvent()
    {
    }
}
