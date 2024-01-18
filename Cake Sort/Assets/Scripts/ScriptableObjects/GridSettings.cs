using UnityEngine;
using Grid = Scripts.Board.Grid;

namespace Scripts.Settings
{
    [CreateAssetMenu(fileName = "GridSettings", menuName = "Settings/GridSettings")]
    public class GridSettings : ScriptableObject
    {
        public Grid gridPrefab;
        public Vector2 gridDistanceOffset;
        public int columnCount;
        public int rowCount;
    }
}