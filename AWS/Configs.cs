using System;
using AWS.InGameEvents;
using EXILED;
using UnityEngine;

namespace AWS {
    public static class Configs {

        public static YamlConfig Config;
        public static float StartTime;
        public static uint BroadcastTime;
        public static string WarheadStart;
        public static string AutoWarheadStart;
        public static string WarheadCancel;
        public static string RoundStart;

        public static void LoadConfig() {
            Config = Plugin.Config;
            StartTime = Config.GetInt("AWS_StartTime");
            BroadcastTime = Config.GetUInt("AWS_BroadcastTime");
            WarheadStart = Config.GetString("AWS_WarheadStart", "");
            AutoWarheadStart = Config.GetString("AWS_AutoWarheadStart", "");
            WarheadCancel = Config.GetString("AWS_WarheadCancel", "");
            RoundStart = Config.GetString("AWS_RoundStart", "");
        }

        public static string getRoundStart() {
            return RoundStart.Replace("[START_TIME]", StartTime.ToString());
        }

        public static float getStartTime() {
            return StartTime * 60;
        }
    }
}
