using UnityEngine;

public class CraftingManager : MonoBehaviour
{
    private Item currentItem;

    public void OnMouseDownItem(Item item)
    {
        if (currentItem == null)
        {
            currentItem = item;
        }
    }

    public void gownozGowno()
    {
        Debug.Log("Lubie w dupe");
    }
}
