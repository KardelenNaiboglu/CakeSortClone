using Scripts.Utils;
using UnityEngine;

namespace Scripts.Board
{
    public class Grid : MonoBehaviour, IInitializable
    {
        #region Variables

        private Vector2Int _coordinates;
        private GridState _gridState;
        
        #endregion

        public void Init()
        {
            _gridState = GridState.Empty;
        }
        
        public void SetCoordinates(int row, int column)
        {
            _coordinates = new Vector2Int(row, column);
        }
        
        public void Dispose()
        {
        }
    }
}