using System.Collections.Generic;
using System.Linq;
using Scripts.Utils;
using UnityEngine;

namespace Scripts.Settings
{
    [CreateAssetMenu(fileName = "CakeSettings", menuName = "Settings/CakeSettings")]
    public class CakeSettings : ScriptableObject
    {
        [SerializeField] private List<CakePieceSettings> cakePieceSettingsList;
        
        public CakePieceSettings GetCakePieceSettings(CakePieceType cakePieceType)
        {
            return cakePieceSettingsList?.FirstOrDefault(t => t.CakePieceType == cakePieceType);
        }
    }
}