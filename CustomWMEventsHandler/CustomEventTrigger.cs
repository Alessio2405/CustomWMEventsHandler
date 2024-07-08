using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomWMEventsHandler
{
    public class CustomEventTrigger
    {
        public void TriggerEvent()
        {
            IntPtr eventHandle = Win32Utility.OpenEvent(Win32Utility.EVENT_ALL_ACCESS, false, GlobalUtility.EventName);
            if (eventHandle != IntPtr.Zero)
            {
                Win32Utility.SetEvent(eventHandle);
            }
            else
            {
                Console.WriteLine("Failed to open event.");
            }
        }
    }
}
