using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace GUISettings
{
    /// <summary>
    /// Syncs the drop down with the Quality setting.
    /// </summary>
    [RequireComponent(typeof(TMP_Dropdown))]
    public class GraphicsQualityDropdown : BaseUILoadSetting
    {
        private TMP_Dropdown dropdown;
        // Start is called before the first frame update
        void Start()
        {
            dropdown = GetComponent<TMP_Dropdown>();
            LoadValue();
            dropdown.onValueChanged.AddListener(delegate { QualitySettings.SetQualityLevel(dropdown.value);});
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public override void LoadValue()
        {
            GetComponent<TMP_Dropdown>().value = QualitySettings.GetQualityLevel();
        }
    }
}
