using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(menuName = "CodeLibrary24/GameEventSystem/Event/Void", fileName = "VoidGameEvent")]
    public class VoidEvent : GameEvent<Void>
    {
        public void Invoke() => Invoke(new Void());
    }
}