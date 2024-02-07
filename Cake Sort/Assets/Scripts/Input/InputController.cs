using Lean.Touch;
using Scripts.Core;
using UnityEngine;

namespace Scripts.Input
{
    public class InputController : MonoBehaviour
    {
        private void OnEnable()
        {
            LeanTouch.OnFingerDown += OnFingerDown;
            LeanTouch.OnFingerUp += OnFingerUp;
            LeanTouch.OnFingerUpdate += OnFingerUpdate;
        }

        private void OnFingerUpdate(LeanFinger leanFinger)
        {
            GameManager.Instance.EventsManager.FingerPositionChanged(leanFinger.ScreenPosition);
        }

        private void OnFingerUp(LeanFinger leanFinger)
        {
            GameManager.Instance.EventsManager.FingerUp(leanFinger.ScreenPosition);
        }

        private void OnFingerDown(LeanFinger leanFinger)
        {
            GameManager.Instance.EventsManager.FingerDown(leanFinger.ScreenPosition);
        }
        
        private void OnDisable()
        {
            LeanTouch.OnFingerDown -= OnFingerDown;
            LeanTouch.OnFingerUp -= OnFingerUp;
            LeanTouch.OnFingerUpdate -= OnFingerUpdate;
        }
    }
}