using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace RedStone
{
    public class TaskManger : Core.Singleton<TaskManger>
    {
        private List<WaitForTask> m_tasks = new List<WaitForTask>();

        public void WaitFor(float seconds, Action callback)
        {
            WaitForTask task = new WaitForTask(seconds, callback);
            m_tasks.Add(task);
        }

        public void Init()
        {

        }

        public void Update()
        {
            for (int i = m_tasks.Count - 1; i >= 0; i--)
            {
                var task = m_tasks[i];
                task.Update();
                try
                {
                    if (task.finished)
                        task.Callback();
                }
                catch (Exception e)
                {
                    Debug.LogError(e.Message + "\n" + e.StackTrace);
                }
            }

            m_tasks.RemoveAll(a => a.finished);
        }
    }

    public class WaitForTask
    {
        private float m_duration = 0;
        private Action m_callback = null;
        public bool finished { get { return m_duration <= 0; } }

        public WaitForTask(float duration, Action callback)
        {
            m_duration = duration;
            m_callback = callback;
        }

        public void Update()
        {
            m_duration -= Time.deltaTime;
        }

        public void Callback()
        {
            if (m_callback != null)
                m_callback.Invoke();
        }
    }

    public static class Task
    {
        public static void WaitFor(float seconds, Action callback)
        {
            TaskManger.instance.WaitFor(seconds, callback);
        }
    }
}