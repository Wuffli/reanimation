using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;

namespace Aarthificial.Reanimation.Editor
{
    public class ReanimatorGraphView : GraphView
    {
        public new class UxmlFactory : UxmlFactory<ReanimatorGraphView, GraphView.UxmlTraits> { }

        public ReanimatorGraphView()
        {

        }
    }
}
