using System;
using EXILED;
using EXILED.Extensions;

namespace AWS {
    public static class Expansions {
        public static void Broadcast(uint time, string message) {
            Map.ClearBroadcasts();
            Map.Broadcast(message, time, false);
            Log.Info($"서버전체 : \"{message}\"을/를 {time}초 동안 보냈습니다.");
        }
    }
}
