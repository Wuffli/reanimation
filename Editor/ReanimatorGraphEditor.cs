using UnityEditor;
using UnityEngine;

namespace Aarthificial.Reanimation.Editor
{
    public class ReanimatorGraphEditor : EditorWindow
    {
        
        [MenuItem("Window/Reanimator/Graph Editor")]
        public static void ShowWindow()
        {
            GetWindow<ReanimatorGraphEditor>("Reanimator Graph Editor");
        }
    }
}
