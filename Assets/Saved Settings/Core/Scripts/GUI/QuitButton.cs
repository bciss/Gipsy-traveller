using UnityEngine;
using UnityEngine.UI;

namespace GUISettings
{
    /// <summary>
    /// Quits the application when the button is pressed.
    /// </summary>
    [RequireComponent(typeof(Button))]
    public class QuitButton : MonoBehaviour
    {
        void Start()
        {
            GetComponent<Button>().onClick.AddListener(delegate { Application.Quit(); });
        }
    }
}
