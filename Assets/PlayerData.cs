[System.Serializable]
public class PlayerData
{
    public float[] position;
    public string[] itemNames; // Store the names of items instead of GameObject instances

    public PlayerData(Player player)
    {
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;

        itemNames = new string[player.inventory.slots.Length];
        for (int i = 0; i < player.inventory.slots.Length; i++)
        {
            // Store the name of the item
            itemNames[i] = player.inventory.item[i] != null ? player.inventory.item[i].name : null;
        }
    }
}
