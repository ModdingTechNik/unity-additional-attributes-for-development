using Interfaces;
using UnityAdditionalAttributes;
using UnityEngine;

// ReSharper disable NotAccessedField.Local

public class GameObjectImplementExample : MonoBehaviour
{
    [SerializeField, GameObjectImplement(typeof(IExample))] private GameObject target;
}