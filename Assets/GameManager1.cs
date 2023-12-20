using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public Player player;

    void Update()
    {
        // Simpan data saat pemain menekan tombol S
        if (Input.GetKeyDown(KeyCode.S))
        {
            player.SavePlayer();
            Debug.Log("Player data saved.");
        }

        // Muat data saat pemain menekan tombol L
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.LoadPlayer();
            Debug.Log("Player data loaded.");
        }
    }
}
