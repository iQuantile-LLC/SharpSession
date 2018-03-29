using System;
using System.Collections.Generic;
using System.Linq;

namespace SessionManager
{
    public static class SharpSession
    {
        /// <summary>
        ///     Session dictionary key:String , Value:Dynamic
        /// </summary>
        public static Dictionary<string, dynamic> Session { get; set; }

        public static int SessionId { get; set; }
        public static string SessionName { get; set; }


        #region SessionMethods

        /// <summary>
        ///     Creates a new session and adds a new sessionID
        /// </summary>
        public static void SessionStart()
        {
            Session = new Dictionary<string, dynamic>();

            SessionId = new Random().Next();
        }

        /// <summary>
        ///     Destory session
        /// </summary>
        public static void SessionDestroy()
        {
            Session = null;
        }

        /// <summary>
        ///     Re initialize session
        /// </summary>
        public static void SessionUnset()
        {
            Session = new Dictionary<string, dynamic>();
        }

        /// <summary>
        ///     Sets null to all keys
        /// </summary>
        public static void SessionReset()
        {
            var keys = Session.Keys.ToList();
            foreach (var key in keys) Session[key] = null;
        }

        /// <summary>
        ///     Returns a new session id
        /// </summary>
        /// <returns>integer</returns>
        public static int CreateId()
        {
            return new Random().Next();
        }

        /// <summary>
        ///     Creats and sets a new sessionID
        /// </summary>
        public static void RegenerateId()
        {
            SessionId = new Random().Next();
        }

        #endregion


        #region FeatureMethods

        /// <summary>
        ///     This Will Return the T type data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get<T>(string key)
        {
            return (T) Session[key];
        }

        public static void Set<T>(string key, T value)
        {
            Session[key] = value;
        }

        #endregion
    }
}