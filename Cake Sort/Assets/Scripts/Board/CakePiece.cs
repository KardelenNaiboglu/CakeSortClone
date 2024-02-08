using Scripts.Settings;
using Scripts.Utils;
using UnityEngine;

namespace Scripts.Board
{
    public class CakePiece : MonoBehaviour, IInitializable
    {
        public CakePieceType CakePieceType
        {
            get
            {
                if (_cakePieceSettings != null) return _cakePieceSettings.CakePieceType;
                return CakePieceType.Cake1;
            }
        }

        private CakePieceSettings _cakePieceSettings;
        [SerializeField] private MeshRenderer meshRenderer;
        
        public void Init()
        {
            if(_cakePieceSettings == null || meshRenderer == null) return;
            
            meshRenderer.materials[0].color = _cakePieceSettings.MainColor;
            meshRenderer.materials[1].color = _cakePieceSettings.SecondaryColor;
        }

        public void SetSettings(CakePieceSettings cakePieceSettings)
        {
            _cakePieceSettings = cakePieceSettings;
        }
        
        public void Dispose()
        {
        }
    }
}