using UnityEngine;

namespace Scripts.Core
{
    [DefaultExecutionOrder(-1000)]
    public class GameManager : MonoBehaviour
    {
        #region PublicGetters
        
        public TaskManager TaskManager => _taskManager;

        #endregion

        #region SystemParts
        
        private TaskManager _taskManager;
        
        #endregion

        #region UnityEvents
        
        private void Awake()
        {
            if (_taskManager != null)
            {
                _taskManager.Dispose();
                _taskManager = null;
            }

            _taskManager = new TaskManager();
            _taskManager.Init();
        }
        
        #endregion
    }
}