using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Player
{
    public int level;
    public string height;
    public Vector3 position;
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Managers")]
    public GUIManager guiManager;
    public AudioManager audioManager;

    [Space]
    public GameObject Player;
    public string height;
    public float squareToMeterRatio;
    public bool pause;
    public GameObject InventoryPanel;
    private  PlayerInputActions input = null;

    private void Awake()
    {
        if (Instance == null) { Instance = this; } else { Destroy(this); }
        DontDestroyOnLoad(this);
        input = new PlayerInputActions();
        Time.timeScale = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Inventory()
    {
        InventoryPanel.gameObject.SetActive(InventoryPanel.activeSelf ? false : true);
    }
    public void Pause()
    {
        guiManager.Pause();
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ReloadLevel()
    {
        Pause();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Save()
    {
        //SaveSystem.SavePlayer(player);
    }

    public void Load()
    {
        //PlayerData playerData = SaveSystem.LoadPlayer();

        //Debug.Log(playerData);
    }
}
