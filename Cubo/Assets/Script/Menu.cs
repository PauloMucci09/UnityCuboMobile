using UnityEngine;

public class Menu : MonoBehaviour
{
    [Header("GameManager")]
    public GameManager _gameManager;

    public void Play()
    {
        _gameManager.Enable();

        Destroy(gameObject);

    }



}
