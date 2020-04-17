﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.﻿

namespace Microsoft.MixedReality.Toolkit.LeapMotion.Input
{
    /// <summary>
    /// The location of the leap motion controller. LeapControllerOrientation.Headset indicates the controller is mounted on a headset. 
    /// LeapControllerOrientation.Desk indicates the controller is placed flat on desk. The default value is set to LeapControllerOrientation.Headset.
    /// </summary>
    public enum LeapControllerOrientation
    {
        /// <summary>
        /// The Leap Motion Controller is mounted on a headset and the hand positions are always calculated relative to the HMD camera.
        /// </summary>
        Headset = 0,

        /// <summary>
        /// The Leap Motion Controller is static and placed flat on a desk. The hand positions are calculated relative to the camera, but can also be configured to 
        /// appear in a different position by modifying the LeapControllerOffset property. Desk hands are primarily used in editor.
        /// </summary>
        Desk
    }
}
