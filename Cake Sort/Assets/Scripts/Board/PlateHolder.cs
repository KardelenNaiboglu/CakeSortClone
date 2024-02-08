using System.Collections.Generic;
using System.Linq;
using Scripts.Utils;
using UnityEngine;

namespace Scripts.Board
{
    public class PlateHolder : MonoBehaviour, IInitializable
    {
        [SerializeField] private Transform cakePieceParent;
        
        private HolderState _holderState;

        public void Init()
        {
        }

        private void SetState(HolderState holderState)
        {
            _holderState = holderState;
        }
        
        public void PlaceInitialCakePieces(List<CakePiece> createdPieces)
        {
            createdPieces = createdPieces.OrderBy(t => t.CakePieceType).ToList();

            for (int i = 0; i < createdPieces.Count; i++)
            {
                createdPieces[i].transform.parent = cakePieceParent;
                createdPieces[i].transform.localPosition = Vector3.zero;
                createdPieces[i].transform.localEulerAngles = new Vector3(0f, i * 60f, 0f);
            }
            
            SetState(HolderState.Idle);
        }
        
        public void Dispose()
        {
        }

      
    }
}