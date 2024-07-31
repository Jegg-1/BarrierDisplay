using UnityEngine;
using System.Collections.Generic;

namespace BarrierDisplay
{
    [DisallowMultipleComponent]
    public class BarrierRenderer : MonoBehaviour
    {
        static List<BarrierRenderer> barriers = new List<BarrierRenderer>();

        Renderer[] renderers = new Renderer[0];

        private void Awake()
        {
            barriers.Add(this);
            Hide();
        }

        public void Show()
        {
            ToggleVisibility(true);
        }

        public void Hide()
        {
            ToggleVisibility(false);
        }

        private void ToggleVisibility(bool visible)
        {
            if (renderers.Length == 0)
                renderers = GetComponentsInChildren<Renderer>();

            foreach (Renderer r in renderers)
                r.enabled = visible;
        }

        private void OnDestroy()
        {
            barriers.Remove(this);
        }
    }
}