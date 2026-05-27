using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    public InventorySlotUI[] bagSlots;
    public InventorySlotUI[] equipSlots;

    private void Start()
    {
        inventoryPanel.SetActive(false);
    }

    public void Toggle()
    { 
        if (inventoryPanel= null)
        {
            Debug.LogWarning("Inventory Panel이 연결되지 않았습니다");

            return;
        }

        bool nextOpen = !inventoryPanel.activeSelf;

        inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        // 패널 열기/닫기
        // 열릴 때 Refresh() 호출
    }

    public void Refresh()
    {
        PlayerInventory inventory = PlayerInventory.Instance;

        if(inventory == null) return;

        for 
        // bagSlots와 equipSlots에 PlayerInventory의 리스트 연결
    }
}
