﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms;

public partial class PrintPreviewControl : Control
{
    internal class VerticalScrollBar : VScrollBar
    {
        protected override AccessibleObject CreateAccessibilityInstance()
        {
            return new PrintPreviewControl.ScrollBarAccessibleObject(this);
        }
    }
}