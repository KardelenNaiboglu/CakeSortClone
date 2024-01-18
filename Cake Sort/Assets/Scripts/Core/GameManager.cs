using Scripts.Attributes;
using Scripts.Board;
using Scripts.Settings;
using UnityEngine;

namespace Scripts.Core
{
    [DefaultExecutionOrder(-1000)]
    public class GameManager : MonoBehaviour
    {
        #region PublicGetters
        
        public TaskManager TaskManager => _taskManager;

        public GridController GridController;
        public static GameManager Instance { get; private set; }

        #endregion

        #region SystemParts

        private TaskManager _taskManager;
        
        #endregion

        #region UnityEvents
        
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            
            if (_taskManager != null)
            {
                _taskManager.Dispose();
                _taskManager = null;
            }

            _taskManager = new TaskManager();
            _taskManager.Init();
            GridController.Init();
        }
        
        #endregion
    }
}