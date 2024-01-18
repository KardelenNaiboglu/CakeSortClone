using UnityEngine;

namespace Scripts.Settings
{
    [CreateAssetMenu(fileName = "TraySettings", menuName = "Settings/TraySettings")]
    public class TraySettings : ScriptableObject
    {
        public int holderCount;
        public GameObject holderPrefab;
    }
}