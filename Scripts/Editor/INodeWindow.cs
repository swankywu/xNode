/***************************************************************************************************
 *  INodeWindow.cs
 *  Project: NBGame
 *
 *  Created by swanky on 8/28/2019
 *  Copyright (c) 2019 swanky.wu@gmail.com. All rights reserved.
***************************************************************************************************/

using UnityEngine;

namespace XNodeEditor
{
    /// <summary>
    /// INodeWindow 
    /// </summary>
    public interface INodeWindow 
    {
        Rect RectPosition{get;set;}
        void RepaintWidow();
    }
}