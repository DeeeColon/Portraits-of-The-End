using UnityEngine;

[CreateAssetMenu]
public class MiniGameCommunicator : ScriptableObject
{
   [SerializeField] public int currentPointsMiniGameOne = 0;
   [SerializeField] public int MiniGameThreePoints = 0;
   [SerializeField] public bool Chopped = false;
   [SerializeField] public int TypingScore = 0;
   [SerializeField] public int CurrentSlotPoints = 0;
   [SerializeField] public int PapersCaught = 0;
   [SerializeField] public bool TimeHasEnded = false;

}
