using EXILED;

namespace AWS.InGameEvents {
    public partial class OnEvents {

        public void OnWarheadStart (WarheadStartEvent ev) {
            if(!IsAutoWarheadStart) {
                Expansions.Broadcast(Configs.BroadcastTime, Configs.WarheadStart);
            }
        }
    }
}
