using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu]
public class ScoreCommunicator : ScriptableObject
{
    [SerializeField]private float _Value;

    public float Value
    {
        get { return _Value; }
        set { _Value = value; }

    }

}
