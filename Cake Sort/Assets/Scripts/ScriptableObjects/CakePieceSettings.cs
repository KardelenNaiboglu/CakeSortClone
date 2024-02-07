using System.Collections;
using System.Collections.Generic;
using Scripts.Utils;
using UnityEngine;

namespace Scripts.Settings
{
    [CreateAssetMenu(fileName = "CakePieceSettings", menuName = "Settings/CakePieceSettings")]
    public class CakePieceSettings : ScriptableObject
    {
        public CakePieceType CakePieceType;
        public Color32 MainColor;
        public Color32 SecondaryColor;
    }
}
