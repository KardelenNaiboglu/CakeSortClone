using System.Collections.Generic;
using Scripts.Settings;
using UnityEngine;

namespace Scripts.Board
{
    public class TrayController : MonoBehaviour, IInitializable
    {
        #region References

        [SerializeField] private TraySettings traySettings;

        #endregion

        #region Variables

        private List<PlateHolder> _plateHolders = new();

        #endregion

        public void Init()
        {
            CreateHolders();
        }
        
        private void CreateHolders()
        {
            if(traySettings == null) return;

            for (int i = 0; i < traySettings.holderCount; i++)
            {
                //TODO
                Instantiate(traySettings.holderPrefab);
            }
        }
        
        public void Dispose()
        {
        }
    }
}