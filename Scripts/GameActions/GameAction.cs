using UnityEngine;

namespace CircusCharlie.GameEventSystem
{
    public abstract class GameAction<T> : ScriptableObject
    {
        [SerializeField] private GameEvent<T> gameEvent;

        public abstract void Invoke();

        protected void Invoke(T data)
        {
            if (gameEvent == null)
            {
                Debug.LogError("No Game event assigned to game action");
            }

            if (data == null)
            {
                Debug.LogError("No data assigned to game action");
            }

            gameEvent.Invoke(data);
        }
    }
}