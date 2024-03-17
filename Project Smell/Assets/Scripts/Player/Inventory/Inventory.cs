using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;

    public int selectedIndex = -1;

    public void SetSelectedIndex(int index)
    {
        selectedIndex = index;
    }

    public int GetSelectedIndex()
    {
        return selectedIndex;
    }
}
