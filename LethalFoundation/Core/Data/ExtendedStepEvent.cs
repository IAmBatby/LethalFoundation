using System;
using System.Collections.Generic;
using System.Text;

namespace LethalFoundation
{
    public enum StepType { Before, On, After }
    public class ExtendedStepEvent
    {
        private ExtendedEvent Before = new ExtendedEvent();
        private ExtendedEvent On = new ExtendedEvent();
        private ExtendedEvent After = new ExtendedEvent();

        public virtual void Invoke()
        {
            Before.Invoke();
            On.Invoke();
            After.Invoke();
        }

        public void AddListener(Action action, StepType stepType)
        {
            if (stepType == StepType.Before) Before.AddListener(action);
            if (stepType == StepType.On) On.AddListener(action);
            if (stepType == StepType.After) After.AddListener(action);
        }

        public void RemoveListener(Action action, StepType stepType)
        {
            if (stepType == StepType.Before) Before.RemoveListener(action);
            if (stepType == StepType.On) On.RemoveListener(action);
            if (stepType == StepType.After) After.RemoveListener(action);
        }

        public virtual void ClearListeners()
        {
            Before.ClearListeners();
            On.ClearListeners();
            After.ClearListeners();
        }
    }

    public class ExtendedStepEvent<T> : ExtendedStepEvent
    {
        private ExtendedEvent<T> ParamBefore = new ExtendedEvent<T>();
        private ExtendedEvent<T> ParamOn = new ExtendedEvent<T>();
        private ExtendedEvent<T> ParamAfter = new ExtendedEvent<T>();

        public void Invoke(T param)
        {
            ParamBefore.Invoke(param);
            ParamOn.Invoke(param);
            ParamAfter.Invoke(param);
            base.Invoke();
        }

        public void AddListener(ParameterEvent<T> action, StepType stepType)
        {
            if (stepType == StepType.Before) ParamBefore.AddListener(action);
            if (stepType == StepType.On) ParamOn.AddListener(action);
            if (stepType == StepType.After) ParamAfter.AddListener(action);
        }

        public void RemoveListener(ParameterEvent<T> action, StepType stepType)
        {
            if (stepType == StepType.Before) ParamBefore.RemoveListener(action);
            if (stepType == StepType.On) ParamOn.RemoveListener(action);
            if (stepType == StepType.After) ParamAfter.RemoveListener(action);
        }

        public override void ClearListeners()
        {
            ParamBefore.ClearListeners();
            ParamOn.ClearListeners();
            ParamAfter.ClearListeners();
            base.ClearListeners();
        }
    }
}
