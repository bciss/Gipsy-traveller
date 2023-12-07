using UnityEngine;
using UnityEngine.UI;

namespace GUISettings
{
    /// <summary>
    /// Syncs the button to changing a player's key bindings.
    /// </summary>
    [RequireComponent(typeof(Button))]
    public class ReloadSceneButton : MonoBehaviour
    {
        void Start()
        {
            GetComponent<Button>().onClick.AddListener(delegate { SceneHelper.Reload(); });
        }
    }
}
