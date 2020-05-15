using System.Collections.Generic;
using EXILED.Extensions;
using MEC;

namespace AWS.InGameEvents {
    public partial class OnEvents {

        private bool IsAutoWarheadStart = false;

        public void OnRoundStart () {
            IsAutoWarheadStart = false;
            Timing.RunCoroutine(AutoWarheadSystem());
            Cassie.CassieMessage($"WARNING THE AUTOMATIC WARHEAD SYSTEM START IN {Configs.StartTime} MINUTES", true, true);
            Expansions.Broadcast(Configs.BroadcastTime, Configs.getRoundStart());
        }

        public IEnumerator<float> AutoWarheadSystem() {
            yield return Timing.WaitForSeconds(Configs.getStartTime());
            if(!Map.IsNukeDetonated) {
                IsAutoWarheadStart = true;
                Map.StartNuke();
                Expansions.Broadcast(Configs.BroadcastTime, Configs.AutoWarheadStart);
            }
        }
    }
}
