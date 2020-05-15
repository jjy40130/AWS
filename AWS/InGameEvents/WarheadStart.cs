using EXILED;

namespace AWS.InGameEvents {
    public partial class OnEvents {

        public void OnWarheadStart (WarheadStartEvent ev) {]
            if(!IsAutoWarheadStart) {
                Expansions.Broadcast(10, "핵이 활성화되었습니다");
            }
        }
    }
}
