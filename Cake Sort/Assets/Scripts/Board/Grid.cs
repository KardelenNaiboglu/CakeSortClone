using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Board
{
    public class Grid : MonoBehaviour
    {
        private Vector2Int _coordinates;
        public void SetCoordinates(int row, int column)
        {
            _coordinates = new Vector2Int(row , column);
        }
    }
}