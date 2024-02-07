using UnityEngine;

namespace Scripts.Board
{
    public class Grid : MonoBehaviour
    {
        #region Variables

        private Vector2Int _coordinates;

        #endregion

        public void SetCoordinates(int row, int column)
        {
            _coordinates = new Vector2Int(row, column);
        }
    }
}