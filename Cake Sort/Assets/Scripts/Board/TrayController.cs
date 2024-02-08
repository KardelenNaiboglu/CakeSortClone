using System.Collections.Generic;
using Scripts.Settings;
using UnityEngine;

namespace Scripts.Board
{
    public class TrayController : MonoBehaviour, IInitializable
    {
        #region References

        [SerializeField] private TraySettings traySettings;
        [SerializeField] private CakeSettings cakeSettings;
        [SerializeField] private Transform holderParent;

        #endregion

        #region Variables

        private List<PlateHolder> _plateHolders = new();

        #endregion

        public void Init()
        {
            CreateHolders();
            FillHolders();
        }

        private void CreateHolders()
        {
            if (traySettings == null) return;
            PlateHolder holder;

            for (int i = 0; i < traySettings.holderCount; i++)
            {
                holder = Instantiate(traySettings.holderPrefab, holderParent);
                holder.transform.localPosition =
                    new Vector3(i * traySettings.distanceBetweenHolders -
                                (traySettings.holderCount / 2 - (traySettings.holderCount % 2 == 0 ? 0.5f : 0f)) *
                                traySettings.distanceBetweenHolders, 0f, 0f);
                _plateHolders.Add(holder);
                holder.Init();
            }
        }

        private void FillHolders()
        {
            int cakeCount;
            CakePiece cakePiece;
            List<CakePiece> createdPieces = new List<CakePiece>();

            for (int i = 0; i < _plateHolders.Count; i++)
            {
                cakeCount = Random.Range(1, 7);

                for (int j = 0; j < cakeCount; j++)
                {
                    cakePiece = Instantiate(cakeSettings.prefabCakePiece);
                    cakePiece.SetSettings(cakeSettings.GetRandomCakePieceSettings());
                    cakePiece.Init();
                    createdPieces.Add(cakePiece);
                }

                _plateHolders[i].PlaceInitialCakePieces(createdPieces);
                createdPieces.Clear();
            }
        }

        public void Dispose()
        {
            if (_plateHolders == null || _plateHolders.Count == 0) return;

            foreach (var holder in _plateHolders)
            {
                Destroy(holder.gameObject);
            }

            _plateHolders.Clear();
        }
    }
}