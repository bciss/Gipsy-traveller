using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace GUISettings
{
    /// <summary>
    /// Syncs the drop down with the Screenmode setting.
    /// </summary>
    [RequireComponent(typeof(TMP_Dropdown))]
    public class ScreenModeSettings : BaseUILoadSetting
    {
        private TMP_Dropdown dropdown;
        // Start is called before the first frame update
        void Start()
        {
            dropdown = GetComponent<TMP_Dropdown>();
            LoadValue();
            dropdown.onValueChanged.AddListener(delegate { SetValue();});
        }

        public void SetValue()
        {
            if (dropdown.value == 0)
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
            else if (dropdown.value == 1)
                Screen.fullScreenMode = FullScreenMode.Windowed;
        }

        public override void LoadValue()
        {
            // TODO : find how to load fullscreenmode
        }
    }
}
