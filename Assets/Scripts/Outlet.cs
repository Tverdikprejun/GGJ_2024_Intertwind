using UnityEngine;

public class Outlet : MonoBehaviour
{
    private CableTip _currentCableTip = null;


    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("WTF");

        if (!other.TryGetComponent<CableTip>(out CableTip otherCableTip)) {  return; }

        _currentCableTip = otherCableTip;

        Debug.Log($"Cable tip found and updated! {_currentCableTip.name}");
    }
}