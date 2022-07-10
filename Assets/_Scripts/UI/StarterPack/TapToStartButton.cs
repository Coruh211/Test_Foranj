using Menus;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapToStartButton : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private bool destroyScript;
    [SerializeField] private bool onPointerDown = true;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        if (!onPointerDown)
            return;

        OnClick();
    }

    public void OnClick()
    {
        GUIManager.Close<StartGameMenu>();
        GUIManager.Open<GameplayMenu>();
        EventManager.OnStartGame.Invoke();

        if (destroyScript)
            Destroy(this);
    }
}
