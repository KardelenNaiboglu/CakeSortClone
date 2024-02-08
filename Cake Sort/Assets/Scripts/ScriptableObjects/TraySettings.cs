using Scripts.Board;
using UnityEngine;

namespace Scripts.Settings
{
    [CreateAssetMenu(fileName = "TraySettings", menuName = "Settings/TraySettings")]
    public class TraySettings : ScriptableObject
    {
        public int holderCount;
        public PlateHolder holderPrefab;
        public float distanceBetweenHolders;
    }
}