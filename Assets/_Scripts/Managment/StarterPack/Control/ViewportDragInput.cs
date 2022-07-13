using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class ViewportDragInput : MonoBehaviour, IDragHandler
{
    /// <summary>
    /// Возвращает 1) дельту смещения и 2) позицию на экране
    /// </summary>
    public static Action<Vector2, Vector2> OnDragPointer;

    public void OnDrag(PointerEventData eventData)
    {
        OnDragPointer?.Invoke(
            new Vector2(eventData.delta.x / Screen.width, eventData.delta.y / Screen.height),
            new Vector2((eventData.position.x / Screen.width * 100), (eventData.position.y / Screen.height) * 100) //Костыль, но так удобнее работать
        );
    }
}