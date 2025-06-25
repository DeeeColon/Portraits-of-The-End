using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu]
public class ScoreCommunicator : ScriptableObject
{
    [SerializeField]private float _Value;
	public bool TobiasDateOneSuccess = false;
    public bool SiennaDateOneSuccess = false;
    public bool SiennaDateOneCompleted = false;
    public bool TobiasDateOneCompleted = false;
    

    public float Value
    {
        get { return _Value; }
        set { _Value = value; }

    }
	
                    
                        

}
