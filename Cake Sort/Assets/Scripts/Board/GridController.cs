using Scripts.Settings;
using UnityEngine;

namespace Scripts.Board
{
    public class GridController : MonoBehaviour
    {
        #region References

        [SerializeField] private GridSettings gridSettings;
        [SerializeField] private Transform gridsParent;
        
        #endregion

        #region Variables

        private Grid[,] _grids;

        #endregion
        
        public void Init()
        {
            CreateGrids();
        }

        private void CreateGrids()
        {
            if (gridSettings == null) return;

            Grid createdGrid;
            _grids = new Grid[gridSettings.rowCount, gridSettings.columnCount];
            
            for (int i = 0; i < gridSettings.columnCount; i++)
            {
                for (int j = 0; j < gridSettings.rowCount; j++)
                {
                    createdGrid = Instantiate(gridSettings.gridPrefab, gridsParent);
                    createdGrid.SetCoordinates(j, i);
                    createdGrid.transform.localPosition = new Vector3(i * gridSettings.gridDistanceOffset.x, 0f,
                        -j * gridSettings.gridDistanceOffset.y);
                    _grids[j, i] = createdGrid;
                }   
            }
          
        }
    }
}