using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomWMEventsHandler
{
    public class CustomEventListener
    {
        private IntPtr _eventHandle;

        public CustomEventListener()
        {
            _eventHandle = Win32Utility.CreateEvent(IntPtr.Zero, false, false, GlobalUtility.EventName);
            if (_eventHandle == IntPtr.Zero)
            {
                throw new InvalidOperationException("Failed to create event.");
            }
        }

        public void StartListening()
        {
            Thread listenerThread = new Thread(ListenForEvents);
            listenerThread.IsBackground = true;
            listenerThread.Start();
        }

        private void ListenForEvents()
        {
            while (true)
            {
                uint result = Win32Utility.WaitForSingleObject(_eventHandle, Win32Utility.INFINITE);
                if (result == 0)
                {
                    HandleCustomEvent();
                }
            }
        }

        private void HandleCustomEvent()
        {
            Console.WriteLine("Custom event received!");
        }
    }
}
