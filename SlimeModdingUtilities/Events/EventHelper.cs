using System;
using System.Linq;

namespace SMU.Events
{
    public static class EventHelper
    {
        /// <summary>
        /// Raises an event, wrapping each delegate in a try/catch. 
        /// Exceptions thrown are logged, using <paramref name="eventName"/> to provide the name of the event the exception was thrown from.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <param name="eventName"></param>
        public static void RaiseEventSafe(this EventHandler e, object sender, string eventName)
        {
            if (e == null) return;
            EventHandler[] handlers = e.GetInvocationList().Select(d => (EventHandler)d).ToArray()
                ?? Array.Empty<EventHandler>();
            for (int i = 0; i < handlers.Length; i++)
            {
                try
                {
                    handlers[i].Invoke(sender, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    Plugin.LogError($"Error in '{eventName}' handlers '{handlers[i]?.Method.Name}': {ex.Message}");
                    Plugin.LogError(ex);
                }
            }
        }

        /// <summary>
        /// Raises an event, wrapping each delegate in a try/catch. 
        /// Exceptions thrown are logged, using <paramref name="eventName"/> to provide the name of the event the exception was thrown from.
        /// </summary>
        /// <typeparam name="TArg"></typeparam>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <param name="eventName"></param>
        public static void RaiseEventSafe<TArg>(this EventHandler<TArg> e, object sender, TArg args, string eventName)
        {
            if (e == null) return;
            EventHandler<TArg>[] handlers = e.GetInvocationList().Select(d => (EventHandler<TArg>)d).ToArray()
                ?? Array.Empty<EventHandler<TArg>>();
            for (int i = 0; i < handlers.Length; i++)
            {
                try
                {
                    handlers[i].Invoke(sender, args);
                }
                catch (Exception ex)
                {
                    Plugin.LogError($"Error in '{eventName}' handlers '{handlers[i]?.Method.Name}': {ex.Message}");
                    Plugin.LogError(ex);
                }
            }
        }


        public static void InvokeAll<T1, T2, T3>(Action<T1, T2, T3> action, params object[] args)
        {
            Delegate[] actions = action?.GetInvocationList();
            if (actions == null) return;
            foreach (Delegate invoc in actions)
            {
                string name = String.Empty;
                try
                {
                    name = invoc?.Method.DeclaringType.Assembly.FullName;
                    invoc?.DynamicInvoke(args);
                }
                catch (Exception ex)
                {
                    Plugin.LogError($"Caught Exception when executing event: {ex.Message}\n In Assembly: {name}");
                    Plugin.LogError(ex.StackTrace);
                }
            }
        }
        public static void InvokeAll<T1, T2>(Action<T1, T2> action, params object[] args)
        {
            Delegate[] actions = action?.GetInvocationList();
            if (actions == null) return;
            foreach (Delegate invoc in actions)
            {
                string name = String.Empty;
                try
                {
                    name = invoc?.Method.DeclaringType.Assembly.FullName;
                    invoc?.DynamicInvoke(args);
                }
                catch (Exception ex)
                {
                    Plugin.LogError($"Caught Exception when executing event: {ex.Message}\n In Assembly: {name}");
                    Plugin.LogError(ex.StackTrace);
                }
            }
        }

        public static void InvokeAll<T>(Action<T> action, params object[] args)
        {
            Delegate[] actions = action?.GetInvocationList();
            if (actions == null) return;
            foreach (Delegate invoc in actions)
            {
                string name = String.Empty;
                try
                {
                    name = invoc?.Method.DeclaringType.Assembly.FullName;
                    invoc?.DynamicInvoke(args);
                }
                catch (Exception ex)
                {
                    Plugin.LogError($"Caught Exception when executing event: {ex.Message}\n In Assembly: {name}");
                    Plugin.LogError(ex.StackTrace);
                }
            }
        }
        public static void InvokeAll(Action action, params object[] args)
        {
            Delegate[] actions = action?.GetInvocationList();
            if (actions == null) return;
            foreach (Delegate invoc in actions)
            {
                string name = String.Empty;
                try
                {
                    name = invoc?.Method.DeclaringType.Assembly.FullName;
                    invoc?.DynamicInvoke(args);
                }
                catch (Exception ex)
                {
                    Plugin.LogError($"Caught Exception when executing event: {ex.Message}\n In Assembly: {name}");
                    Plugin.LogError(ex.StackTrace);
                }
            }
        }
    }
}
