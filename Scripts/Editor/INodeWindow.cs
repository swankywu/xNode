/***************************************************************************************************
 *  INodeWindow.cs
 *  Project: NBGame
 *
 *  Created by swanky on 8/28/2019
 *  Copyright (c) 2019 swanky.wu@gmail.com. All rights reserved.
***************************************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;

namespace XNodeEditor
{
    /// <summary>
    /// INodeWindow 
    /// </summary>
    public interface INodeWindow
    {
        Rect RectPosition { get; set; }
        NodeGraphEditor graphEditor{get; set;}
        Dictionary<XNode.NodePort, Rect> portConnectionPoints { get; }

        void RepaintWindow();
        event Action onLateGUI;

        void MoveNodeToTop(XNode.Node node);
        void RenameSelectedNode();
        void CopySelectedNodes();
        void DuplicateSelectedNodes();
        void RemoveSelectedNodes();
        void PasteNodes(Vector2 pos);

        Vector2 WindowToGridPosition(Vector2 windowPosition); 


    }

    public static class NodeWindowManager
    {
        public static INodeWindow current;
    }
}