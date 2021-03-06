using System.Collections;
using System.Timers;
using Plugins;
using Core;
using System;

namespace RedStone
{
    public class GameManager : Core.Singleton<GameManager>, Core.IUpdateable
    {
        private Updater m_updater = new Updater();
        public EventManager eventManager { get; private set; }

        public void Start()
        {
            eventManager = new EventManager();
            TaskManger.CreateInstance().Init();
            TableManager.CreateInstance();
            TableManager.instance.getTypeFunc = (name) => { return Type.GetType(name); };
            TableManager.instance.Init();
            NetworkManager.CreateInstance().Init();
            ProxyManager.CreateInstance().Init();


            // start server
            NetworkManager.instance.forClient.server.Start();
            Debug.LogInfo("战场服务器已启动");
            // connect to main server
            ProxyManager.instance.GetProxy<MainServerProxy>().Connenct();


            m_updater.Start();
            m_updater.Add(this);
            m_updater.Add(ProxyManager.instance);

            Time.SetUpdater(m_updater);
        }

        private void OnDestroy()
        {
            m_updater.Clear();
        }

        private void OnApplicationQuit()
        {

        }

        public void Update()
        {
            TaskManger.instance.Update();
        }

    }
}