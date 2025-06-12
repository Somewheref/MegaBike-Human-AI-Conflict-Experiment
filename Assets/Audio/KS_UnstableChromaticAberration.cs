using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


    [RequireComponent(typeof(Volume))]
    public class UnstableChromaticAberration : MonoBehaviour
    {
        [Header("Chromatic Aberration Settings")]
        public float baseIntensity = 0.1f;        // Center value around which to fluctuate (0-1)
        public float variationRange = 0.05f;      // Max random offset from base
        public float updateInterval = 0.1f;       // How often to pick a new random target in seconds
        public float smoothTime = 0.2f;           // Time to smooth toward the new target

        private Volume volume;
        private ChromaticAberration chromatic;
        private float currentVelocity;
        private float targetIntensity;

        void Awake()
        {
            volume = GetComponent<Volume>();
            if (volume.profile == null)
            {
                Debug.LogError("Volume has no profile assigned.", this);
                enabled = false;
                return;
            }

            // Try to get the Chromatic Aberration override
            if (!volume.profile.TryGet<ChromaticAberration>(out chromatic))
            {
                Debug.LogError("ChromaticAberration not found in Volume Profile.", this);
                enabled = false;
                return;
            }
        }

        void OnEnable()
        {
            // Initialize
            targetIntensity = baseIntensity;
            chromatic.intensity.value = baseIntensity;
            StartCoroutine(UpdateIntensityRoutine());
        }

        void OnDisable()
        {
            StopAllCoroutines();
        }

        void Update()
        {
            // Smoothly interpolate current intensity toward the target
            float newVal = Mathf.SmoothDamp(chromatic.intensity.value, targetIntensity, ref currentVelocity, smoothTime);
            chromatic.intensity.value = Mathf.Clamp01(newVal);
        }

        private IEnumerator UpdateIntensityRoutine()
        {
            while (true)
            {
                // Pick a new random target around baseIntensity
                float offset = Random.Range(-variationRange, variationRange);
                targetIntensity = Mathf.Clamp01(baseIntensity + offset);

                yield return new WaitForSeconds(updateInterval);
            }
        }
    }

