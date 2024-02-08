using System;
using UnityEngine;

namespace Scripts.Events
{
    public class EventsManager : IInitializable
    {
        public Action<Vector3> OnFingerDown;
        public Action<Vector3> OnFingerPositionChanged;
        public Action<Vector3> OnFingerUp;

        public void Init()
        {
        }

        #region InputEvents

        public void FingerDown(Vector3 pos)
        {
            OnFingerDown?.Invoke(pos);
        }

        public void FingerPositionChanged(Vector3 pos)
        {
            OnFingerPositionChanged?.Invoke(pos);
        }

        public void FingerUp(Vector3 pos)
        {
            OnFingerUp?.Invoke(pos);
        }

        #endregion

        public void Dispose()
        {
        }
    }
}