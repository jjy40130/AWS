using System.Collections.Generic;
using EXILED.Extensions;
using MEC;

namespace AWS.InGameEvents {
    public partial class OnEvents {

        private bool IsAutoWarheadStart = false;

        public void OnRoundStart () {
            IsAutoWarheadStart = false;
            Timing.RunCoroutine(AutoWarheadSystem());
            Cassie.CassieMessage("WARNING THE AUTOMATIC WARHEAD SYSTEM START IN 30 SECOND", true, true);
            Expansions.Broadcast(10, "경고! 30초뒤 자동핵 시스템이 동작합니다!");
        }

        public IEnumerator<float> AutoWarheadSystem() {
            yield return Timing.WaitForSeconds(30f);
            if(!Map.IsNukeDetonated) {
                IsAutoWarheadStart = true;
                Map.StartNuke();
                Expansions.Broadcast(10, "자동핵이 활성화되었습니다\n비활성화가 불가능합니다");
            }
        }
    }
}
