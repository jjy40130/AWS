using System;
using AWS.InGameEvents;
using EXILED;

namespace AWS {
    public class MainClass : Plugin {

        public override string getName => "AWS";
        OnEvents onEvents;

        public override void OnEnable() {
            onEvents = new OnEvents();
            Log.Info("이벤트 불러오는중...");
            Events.RoundStartEvent += onEvents.OnRoundStart;
            Events.WarheadStartEvent += onEvents.OnWarheadStart;
            Events.WarheadCancelledEvent += onEvents.OnWarheadCancel;
            Log.Info("이벤트를 정상적으로 불러왔습니다.");
            Log.Info("AWS 플러그인이 정상적으로 활성화되었습니다!");
        }

        public override void OnDisable() {
            Log.Info("이벤트 해제하는중...");
            Events.RoundStartEvent -= onEvents.OnRoundStart;
            Events.WarheadStartEvent -= onEvents.OnWarheadStart;
            Events.WarheadCancelledEvent -= onEvents.OnWarheadCancel;
            Log.Info("이벤트를 정상적으로 해제하였습니다.");
            Log.Info("AWS 플러그인이 정상적으로 비활성화되었습니다.");
        }

        public override void OnReload() {
            Log.Info("AWS 플러그인이 재시작중입니다.");
        }
    }
}
