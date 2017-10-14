﻿/*************************************************************************
 *  Copyright (C), 2016-2017, Mogoson Tech. Co., Ltd.
 *------------------------------------------------------------------------
 *  File         :  ClockUI.cs
 *  Description  :  Draw UI in scene to control clock.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  4/5/2016
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace Developer.Meter
{
    [AddComponentMenu("Developer/Meter/ClockUI")]
    public class ClockUI : MonoBehaviour
    {
        #region Property and Field
        public float xOffset = 10;
        public float yOffset = 10;
        public Clock clock;
        #endregion

        #region Private Method
        private void OnGUI()
        {
            GUILayout.Space(yOffset);
            GUILayout.BeginHorizontal();
            GUILayout.Space(xOffset);
            GUILayout.BeginVertical();

            if (GUILayout.Button("Turn On"))
                clock.TurnOn();
            if (GUILayout.Button("Turn Off"))
                clock.TurnOff();

            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }
        #endregion
    }
}