using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace BarrierDisplay.Editor
{
    public class BarrierDisplayMenu : EditorWindow
    {
        [MenuItem("Tools/Barrier Display Menu")]
        public static void OpenMenu()
        {
            BarrierDisplayMenu window = GetWindow<BarrierDisplayMenu>();
            window.titleContent = new GUIContent("Barrier Display Menu");
        }

        void CreateGUI()
        {
            Label header = new Label("Barrier Display Menu");
            header.style.fontSize = 30;
            header.style.unityFontStyleAndWeight = FontStyle.Bold;
            header.style.alignSelf = Align.Center;
            header.style.paddingTop = 10;
            header.style.paddingBottom = 10;

            Button showButton = new Button() { name = "showButton", text = "Show Barriers" };
            Button hideButton = new Button() { name = "hideButton", text = "Hide Barriers" };
            showButton.style.height = 30;
            showButton.style.marginBottom = 10;
            hideButton.style.height = 30;

            showButton.clicked += ShowColliders;
            hideButton.clicked += HideColliders;

            rootVisualElement.Add(header);
            rootVisualElement.Add(showButton);
            rootVisualElement.Add(hideButton);
        }

        void ShowColliders()
        {
            BarrierRenderer[] clips = FindObjectsOfType<BarrierRenderer>();

            foreach (BarrierRenderer clip in clips)
                clip.Show();
        }

        void HideColliders()
        {
            BarrierRenderer[] clips = FindObjectsOfType<BarrierRenderer>();

            foreach (BarrierRenderer clip in clips)
                clip.Hide();
        }
    }
}