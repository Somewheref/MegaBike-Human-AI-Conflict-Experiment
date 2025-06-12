using Obvious.Soap;
using UnityEngine;
using DG.Tweening;

public class PlayerHeartBeat : MonoBehaviour
{
    [Header("References")]
        [Tooltip("The heart image transform to scale.")]
        public Transform heartImage;
        [Tooltip("Controls the heartbeat speed: 0 = slowest, 1 = fastest.")]
        public FloatVariable strengthUsing;

        [Header("Scale Settings")]
        public float minScale = 1f;
        public float maxScale = 1.5f;

        [Header("Pulse Duration Settings")]
        [Tooltip("Duration of one full beat cycle (up + down) at lowest strength).")]
        public float minDuration = 0.5f;
        [Tooltip("Duration of one full beat cycle at highest strength).")]
        public float maxDuration = 0.2f;
        public Ease easeType = Ease.OutBack;

        private Tween _beatTween;

        void Reset()
        {
            if (heartImage == null)
                heartImage = transform;
        }

        void Start()
        {
            PlayBeat();
        }

        void OnDisable()
        {
            _beatTween?.Kill();
        }

        private void PlayBeat()
        {
            // Kill any existing tween before starting a new one
            if (_beatTween != null && _beatTween.IsActive())
                _beatTween.Kill();

            float strength = strengthUsing != null ? strengthUsing.Value : 0f;
            float duration = CalculateDuration(strength);

            // Tween to maxScale then back to minScale (yoyo), then restart on complete
            _beatTween = heartImage
                .DOScale(maxScale, duration)
                .SetEase(easeType)
                .SetLoops(2, LoopType.Yoyo)
                .OnComplete(PlayBeat);
        }

        private float CalculateDuration(float strength)
        {
            // Clamp strength to [0,1], then map to [minDuration, maxDuration]
            float t = Mathf.Clamp01(strength);
            return Mathf.Lerp(minDuration, maxDuration, t);
        }

        /// <summary>
        /// Returns current heartbeat rate in beats per second.
        /// </summary>
        public float GetBeatsPerSecond()
        {
            float strength = strengthUsing != null ? strengthUsing.Value : 0f;
            float duration = CalculateDuration(strength);
            return duration > 0f ? 1f / duration : 0f;
        }
}
