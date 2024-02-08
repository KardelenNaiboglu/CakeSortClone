using Scripts.Board;
using Scripts.Events;
using UnityEngine;

namespace Scripts.Core
{
    [DefaultExecutionOrder(-1000)]
    public class GameManager : MonoBehaviour
    {
        #region PublicGetters
        
        public TaskManager TaskManager => _taskManager;
        public EventsManager EventsManager => _eventsManager;

        public GridController GridController;
        public TrayController TrayController;
        public static GameManager Instance { get; private set; }

        #endregion

        #region SystemParts

        private TaskManager _taskManager;
        private EventsManager _eventsManager;
        
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

            if (_eventsManager != null)
            {
                _eventsManager.Dispose();
                _eventsManager = null;
            }

            _taskManager = new TaskManager();
            _taskManager.Init();

            _eventsManager = new EventsManager();
            _eventsManager.Init();
            
            GridController.Init();
            TrayController.Init();
        }
        
        #endregion
    }
}