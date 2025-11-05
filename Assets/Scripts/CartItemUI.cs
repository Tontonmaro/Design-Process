using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CartItemUI : MonoBehaviour
{
    public TextMeshProUGUI quantityText;
    public Button increaseButton;
    public Button decreaseButton;

    private ItemDetails linkedItem;
    private ItemSelect itemSelect;

    public void Setup(ItemDetails item, ItemSelect select)
    {
        linkedItem = item;
        itemSelect = select;
        UpdateUI();
        
        increaseButton.onClick.AddListener(IncreaseQuantity);
        decreaseButton.onClick.AddListener(DecreaseQuantity);
    }

    void IncreaseQuantity()
    {
        linkedItem.quantity++;
        linkedItem.quantity = Mathf.Min(linkedItem.quantity, 20);
        UpdateUI();
    }

    void DecreaseQuantity()
    {
        linkedItem.quantity = Mathf.Max(1, linkedItem.quantity - 1);
        UpdateUI();
    }

    void UpdateUI()
    {
        quantityText.text = linkedItem.quantity.ToString();
        itemSelect.refreshPrice();
    }
}
