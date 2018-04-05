﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MegaStore.Helper
{
    public class Env
    {
        private static Dictionary<string, string> _Values = new Dictionary<string, string>();

        public static string MessageQueueUrl { get { return Get("MESSAGE_QUEUE_URL"); } }

        public static string DbConnectionString { get { return Get("DB_CONNECTION_STRING"); } }

        private static string Get(string variable)
        {
            if (!_Values.ContainsKey(variable))
            {
                var value = Environment.GetEnvironmentVariable(variable);
                _Values[variable] = value;
            }
            return _Values[variable];
        }
    }
}