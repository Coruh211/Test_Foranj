using System;
using UnityEngine;

public class TapInput : Singleton<TapInput>
{
    public Action OnTapDown;
    public Action OnTapUp;
    
    private bool isTapped;
    public bool IsTapped => isTapped;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            OnTapDown?.Invoke();
        else if (Input.GetMouseButtonUp(0))
            OnTapUp?.Invoke();

        isTapped = Input.GetMouseButton(0);
    }
}