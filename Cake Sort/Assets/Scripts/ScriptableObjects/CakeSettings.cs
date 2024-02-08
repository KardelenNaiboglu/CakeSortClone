using System.Collections.Generic;
using System.Linq;
using Scripts.Board;
using Scripts.Utils;
using UnityEngine;

namespace Scripts.Settings
{
    [CreateAssetMenu(fileName = "CakeSettings", menuName = "Settings/CakeSettings")]
    public class CakeSettings : ScriptableObject
    {
        public CakePiece prefabCakePiece;
        
        [SerializeField] private List<CakePieceSettings> cakePieceSettingsList;
        
        public CakePieceSettings GetCakePieceSettings(CakePieceType cakePieceType)
        {
            return cakePieceSettingsList?.FirstOrDefault(t => t.CakePieceType == cakePieceType);
        }

        public CakePieceSettings GetRandomCakePieceSettings()
        {
            return cakePieceSettingsList[Random.Range(0, cakePieceSettingsList.Count)];
        }
    }
}