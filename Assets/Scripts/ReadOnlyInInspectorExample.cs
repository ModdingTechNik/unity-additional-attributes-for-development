using UnityAdditionalAttributes;
using UnityEngine;

// ReSharper disable NotAccessedField.Local

public class ReadOnlyInInspectorExample : MonoBehaviour
{
    [SerializeField, ReadOnlyInInspector] private byte @byte = 255;
    [SerializeField, ReadOnlyInInspector] private sbyte sByte = -127;
    [SerializeField, ReadOnlyInInspector] private short @short = -12600;
    [SerializeField, ReadOnlyInInspector] private ushort uShort = 12600;
    [SerializeField, ReadOnlyInInspector] private int @int = -583;
    [SerializeField, ReadOnlyInInspector] private uint uInt = 583;
    [SerializeField, ReadOnlyInInspector] private long @long = -683559;
    [SerializeField, ReadOnlyInInspector] private ulong uLong = 683559;
    [SerializeField, ReadOnlyInInspector] private float @float = 0.3589f;
    [SerializeField, ReadOnlyInInspector] private double @double = 0.7578365;
    [SerializeField, ReadOnlyInInspector] private decimal @decimal = 0.4378M;
    [SerializeField, ReadOnlyInInspector] private string @string = "READ-ONLY";
    [SerializeField, ReadOnlyInInspector] private bool boolean = true;
    [SerializeField, ReadOnlyInInspector] private Vector2 vector2 = new Vector2(1 ,7.5f);
    [SerializeField, ReadOnlyInInspector] private Vector2Int vector2Int = new Vector2Int(1 ,3);
    [SerializeField, ReadOnlyInInspector] private Vector3 vector3 = new Vector3(1 ,6.5f, 7);
    [SerializeField, ReadOnlyInInspector] private Vector3Int vector3Int = new Vector3Int(1 ,9, 6);
}