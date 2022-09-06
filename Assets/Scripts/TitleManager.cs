using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{

    [SerializeField] private TMP_InputField _nameTextInput;
    // Start is called before the first frame update
    public void StartGame()
    {
        Player player = new Player();
        player.Name = _nameTextInput.text;

        GameManager.Instance.Player = player;
        SceneManager.LoadScene(1);
    }
}
