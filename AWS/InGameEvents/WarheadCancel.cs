using EXILED;

namespace AWS.InGameEvents {
    public partial class OnEvents {

        public void OnWarheadCancel (WarheadCancelEvent ev) {
            if(IsAutoWarheadStart) {
                ev.Allow = false;
            } else {
                Expansions.Broadcast(10, "핵작동이 취소되었습니다");
            }
        }
    }
}
