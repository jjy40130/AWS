using EXILED;

namespace AWS.InGameEvents {
    public partial class OnEvents {

        public void OnWarheadCancel (WarheadCancelEvent ev) {
            if(IsAutoWarheadStart) {
                ev.Allow = false;
            } else {
                Expansions.Broadcast(Configs.BroadcastTime, Configs.WarheadCancel);
            }
        }
    }
}
