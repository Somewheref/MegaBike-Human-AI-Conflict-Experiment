using UnityEngine;
using TMPro;
using System.Collections.Generic;
using KayphoonStudio;
using UnityEngine.InputSystem;
using Doozy.Runtime.UIManager.Components;
using Doozy.Runtime.Reactor;

public class OwdiSacrificeUI : MonoBehaviour
{
    public Animation anim;
    public Progressor progressor;

    public Transform sacrificeItemsParent;
    public GameObject sacrificeItemPrefab;

    private List<OwdiSacrificeItemUI> sacrificeItems = new List<OwdiSacrificeItemUI>();
    private int currentSelectedIndex = -1;
    [SerializeField] private int gridColumns = 4;

    private void Awake()
    {
        InputSystem.onActionChange += OnInputActionTriggered;
    }

    void Start()
    {
        KS_NotificationCenter.AddEventListener(NKeys.OnOwdiSacrificeStart, ShowPanel);
    }

    private void OnDestroy()
    {
        InputSystem.onActionChange -= OnInputActionTriggered;
    }

    public void ShowPanel()
    {
        anim.Play("OwdiSacrificePanel_Show");
        Utils.DestroyAllChildren(sacrificeItemsParent);
        sacrificeItems.Clear();

        List<AgentInfo> agentInfoList = PlayerDataStorer.Instance.GetAllAgentDataInfo();
        foreach (var agentInfo in agentInfoList)
        {
            if (agentInfo.isDead) continue;
            AddSacrificeItem(agentInfo);
        }

        if (sacrificeItems.Count > 0)
        {
            SelectItem(0);
        }

        // progressor.Play(PlayDirection.Forward);
        progressor.SetValueAt(0.5f);
        progressor.PlayToValue(0);

        KS_Timer.DelayedAction(2f, () =>
        {
            progressor.Play(PlayDirection.Forward);
        });
    }

    public void HidePanel()
    {
        anim.Play("OwdiSacrificePanel_Hide");
        SacrificeCurrentSelection();
    }

    public void AddSacrificeItem(AgentInfo agentInfo)
    {
        GameObject item = Instantiate(sacrificeItemPrefab, sacrificeItemsParent);
        var sacrificeItem = item.GetComponent<OwdiSacrificeItemUI>();
        sacrificeItem.SetItem(
            agentInfo,
            OnItemClicked,      // Click callback
            OnItemHovered       // Hover callback
        );
        sacrificeItems.Add(sacrificeItem);
    }

    private void OnInputActionTriggered(object obj, InputActionChange change)
    {
        if (change != InputActionChange.ActionPerformed) return;
        
        var action = obj as InputAction;
        if (action == null) return;

        switch (action.name)
        {
            case "Navigate":
                Vector2 movement = action.ReadValue<Vector2>();
                HandleNavigation(movement);
                break;
        }
    }

    private void HandleNavigation(Vector2 movement)
    {
        if (sacrificeItems.Count == 0) return;

        int newIndex = currentSelectedIndex;
        int totalItems = sacrificeItems.Count;
        int currentRow = currentSelectedIndex / gridColumns;
        int currentCol = currentSelectedIndex % gridColumns;
        int totalRows = Mathf.CeilToInt((float)totalItems / gridColumns);
        
        if (Mathf.Abs(movement.x) > 0.5f)
        {
            // Horizontal movement
            if (movement.x > 0)
            {
                // Moving right
                if (currentCol == gridColumns - 1 || currentSelectedIndex == totalItems - 1)
                    newIndex = currentRow * gridColumns; // Wrap to start of row
                else
                    newIndex++;
            }
            else
            {
                // Moving left
                if (currentCol == 0)
                    newIndex = Mathf.Min(currentRow * gridColumns + gridColumns - 1, totalItems - 1); // Wrap to end of row
                else
                    newIndex--;
            }
        }
        else if (Mathf.Abs(movement.y) > 0.5f)
        {
            // Vertical movement
            if (movement.y < 0)
            {
                // Moving down
                int nextRow = (currentRow + 1) % totalRows;
                int nextIndex = nextRow * gridColumns + currentCol;
                
                // If the target position would be beyond the last item
                if (nextIndex >= totalItems)
                {
                    // Either wrap to first row or move to last item in grid
                    nextIndex = (nextRow == 0) ? currentCol : totalItems - 1;
                }
                newIndex = nextIndex;
            }
            else
            {
                // Moving up
                int nextRow = (currentRow - 1 + totalRows) % totalRows;
                int nextIndex = nextRow * gridColumns + currentCol;
                
                // If the target position would be beyond the last item
                if (nextIndex >= totalItems)
                {
                    nextIndex = totalItems - 1;
                }
                newIndex = nextIndex;
            }
        }

        if (newIndex != currentSelectedIndex)
        {
            SelectItem(newIndex);
        }
    }

    private void SelectItem(int index)
    {
        if (currentSelectedIndex >= 0 && currentSelectedIndex < sacrificeItems.Count)
        {
            sacrificeItems[currentSelectedIndex].DeselectItem();
        }

        currentSelectedIndex = index;
        sacrificeItems[currentSelectedIndex].SelectItem();

        Debug.Log("Selected Agent: " + sacrificeItems[currentSelectedIndex].GetAgentInfo().agentName);
    }

    public void SacrificeCurrentSelection()
    {
        if (currentSelectedIndex >= 0 && currentSelectedIndex < sacrificeItems.Count)
        {
            AgentInfo agentInfo = sacrificeItems[currentSelectedIndex].GetAgentInfo();

            KS_NotificationCenter.DispatchEvent(NKeys.OnOwdiSacrificeEnd, agentInfo);
            KS_Logger.Log("Sacrifice " + agentInfo.agentName);
        }
        else
        {
            KS_Logger.LogWarning("No selection to sacrifice, currentSelectedIndex: " + currentSelectedIndex);
        }
    }

    private void OnItemClicked(OwdiSacrificeItemUI item)
    {
        int index = sacrificeItems.IndexOf(item);
        if (index != -1)
        {
            SelectItem(index);
            // SacrificeCurrentSelection(); // Optional: auto-sacrifice on click
        }
    }

    private void OnItemHovered(OwdiSacrificeItemUI item)
    {
        // int index = sacrificeItems.IndexOf(item);
        // if (index != -1)
        // {
        //     SelectItem(index);
        // }
    }
}
