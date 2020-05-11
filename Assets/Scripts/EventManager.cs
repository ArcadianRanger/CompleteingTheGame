using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    [System.Serializable] public class TargetDestroy : UnityEvent<int> { }
    
    public TargetDestroy targetDestroy;
}
