//using System;
//using System.Diagnostics.Tracing;
//using System.Windows;

//namespace MemoryLeaksDemo.WeakEventManagerExample
//{
//    class SomeEventWeakEventManager : WeakEventManager
//    {
//        private SomeEventWeakEventManager()
//        {

//        }

//        /// <summary>
//        /// Add a handler for the given source's event.
//        /// </summary>
//        public static void AddHandler(EventSource source,
//                                      EventHandler<EventArgs> handler)
//        {
//            if (source == null)
//                throw new ArgumentNullException("source");
//            if (handler == null)
//                throw new ArgumentNullException("handler");

//            CurrentManager.ProtectedAddHandler(source, handler);
//        }

//        /// <summary>
//        /// Remove a handler for the given source's event.
//        /// </summary>
//        public static void RemoveHandler(EventSource source,
//                                         EventHandler<EventArgs> handler)
//        {
//            if (source == null)
//                throw new ArgumentNullException("source");
//            if (handler == null)
//                throw new ArgumentNullException("handler");

//            CurrentManager.ProtectedRemoveHandler(source, handler);
//        }

//        /// <summary>
//        /// Get the event manager for the current thread.
//        /// </summary>
//        private static SomeEventWeakEventManager CurrentManager
//        {
//            get
//            {
//                Type managerType = typeof(SomeEventWeakEventManager);
//                SomeEventWeakEventManager manager =
//                    (SomeEventWeakEventManager)GetCurrentManager(managerType);

//                // at first use, create and register a new manager
//                if (manager == null)
//                {
//                    manager = new SomeEventWeakEventManager();
//                    SetCurrentManager(managerType, manager);
//                }

//                return manager;
//            }
//        }

//        /// <summary>
//        /// Return a new list to hold listeners to the event.
//        /// </summary>
//        protected override ListenerList NewListenerList()
//        {
//            return new ListenerList<EventArgs>();
//        }


//        /// <summary>
//        /// Listen to the given source for the event.
//        /// </summary>
//        protected override void StartListening(object source)
//        {
//            EventSource typedSource = (EventSource)source;
//            typedSource.SampleEvent += new EventHandler<EventArgs>(OnSomeEvent);
//        }

//        /// <summary>
//        /// Stop listening to the given source for the event.
//        /// </summary>
//        protected override void StopListening(object source)
//        {
//            EventSource typedSource = (EventSource)source;
//            typedSource.SomeEvent -= new EventHandler<EventArgs>(OnSomeEvent);
//        }

//        /// <summary>
//        /// Event handler for the SomeEvent event.
//        /// </summary>
//        void OnSomeEvent(object sender, EventArgs e)
//        {
//            DeliverEvent(sender, e);
//        }
//    }
//}