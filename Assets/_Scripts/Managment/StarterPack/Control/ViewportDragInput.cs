using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class ViewportDragInput : MonoBehaviour, IDragHandler
{
    /// <summary>
    /// ���������� 1) ������ �������� � 2) ������� �� ������
    /// </summary>
    public static Action<Vector2, Vector2> OnDragPointer;

    public void OnDrag(PointerEventData eventData)
    {
        OnDragPointer?.Invoke(
            new Vector2(eventData.delta.x / Screen.width, eventData.delta.y / Screen.height),
            new Vector2(eventData.position.x / Screen.width, eventData.position.y / Screen.height)
        );
    }
}