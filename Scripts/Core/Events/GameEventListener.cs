using UnityEngine;
using UnityEngine.Events;

namespace CircusCharlie.GameEventSystem
{
    public abstract class GameEventListener<T, E, U> : MonoBehaviour, IGameEventListener<T> where E : GameEvent<T> where U : UnityEvent<T>
    {
        [SerializeField] private E gameEvent;

        public E GameEvent
        {
            get
            {
                return gameEvent;
            }
            set
            {
                gameEvent = value;
            }
        }

        [SerializeField] private U unityEventResponse;

        private void OnEnable()
        {
            if (gameEvent == null)
            {
                return;
            }
            GameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (gameEvent == null)
            {
                return;
            }

            GameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T data)
        {
            if (unityEventResponse != null)
            {
                unityEventResponse.Invoke(data);
            }
        }
    }
}