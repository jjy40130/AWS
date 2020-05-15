# AutoWarhead System (AWS)
본 플러그인은 존버 및 오랜 라운드진행으로 지루해지는 SL을 방지하고자 제작된 SCP_SL 전용 플러그인입니다.


 - 라운드 마다 지정한 시간에 자동핵 시스템이 활성화됩니다.
 - 활성화된 자동핵은 어떠한 경우에도 취소가 불가능합니다


# Using Config File
본 플러그인은 Config파일을 지원하고 있습니다.
https://github.com/jjy40130/AWS/blob/master/Config.txt

Config 파일 사용방법 : .config/EXILED/포트-config.yml에 위 config를 추가 또는 덮어쓰기하면 됩니다.

< Config 설명 >\
AWS_StartTime : 라운드 시작 이후 자동핵이 동작될때 까지의 시간입니다. ( 단위 : 분 )
AWS_BroadcastTime : 안내메시지을 표시할 시간입니다. ( 단위 : 초 )
AWS_WarheadStart : 일반적인 핵작동시 안내될 메시지입니다.
AWS_AutoWarheadStart : 자동핵 작동시 안내될 메시지입니다.
AWS_WarheadCancel : 일반적인 핵작동 취소시 안내될 메시지입니다.
AWS_RoundStart : 라운드 시작 직후 안내될 메시지입니다. ( [START_TIME] : 자동핵이 작동될 시간이 반환됩니다. ( 단위 : 분 ))


# Precautions

 - Config 파일은 무조건 추가 또는 덮어쓰기 하셔야됩니다.
 - 핵 이벤트 관련 이벤트가 적용되어 있는 플러그인과 함께 사용시 오류가 발생할 수 있습니다.
