using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class ResolutionValues
{
    public int x;
    public int y;
    public string name;
}

namespace GUISettings
{
    /// <summary>
    /// Syncs the drop down with the Quality setting.
    /// </summary>
    [RequireComponent(typeof(TMP_Dropdown))]
    public class ResolutionSettings : BaseUILoadSetting
    {
        private TMP_Dropdown dropdown;
        [SerializeField]
        public List<ResolutionValues> resolutionValues;
        // Start is called before the first frame update
        void Start()
        {
            dropdown = GetComponent<TMP_Dropdown>();
            LoadValue();
            dropdown.onValueChanged.AddListener(delegate { SetValue();});
        }

        public void SetValue()
        {
            Screen.SetResolution(resolutionValues[dropdown.value].x, resolutionValues[dropdown.value].y, false);
            Debug.Log(Screen.currentResolution);
        }

        public override void LoadValue()
        {
            // TODO : find how to load fullscreenmode
        }
    }
}