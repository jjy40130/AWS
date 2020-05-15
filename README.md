# AutoWarhead System (AWS)
본 플러그인은 존버 및 오랜 라운드진행으로 지루해지는 SL을 방지하고자 제작된 SCP_SL 전용 플러그인입니다.

! 라운드 마다 지정한 시간에 자동핵 시스템이 활성화됩니다.
! 활성화된 자동핵은 어떠한 경우에도 취소가 불가능합니다

# Using Config File
본 플러그인은 Config파일을 지원하고 있습니다.

`
AWS_StartTime: 1 
AWS_BroadcastTime: 10
AWS_WarheadStart: 긴급 핵시스템 절차가 시작되었습니다
AWS_AutoWarheadStart: 자동핵시스템 절차가 시작되었습니다\n취소가 불가능합니다
AWS_WarheadCancel: 핵시스템 절차가 취소되었습니다
AWS_RoundStart: [START_TIME]분 후 자동핵시스템이 동작합니다
`

Config 파일 사용방법 : .config/EXILED/포트-config.yml에 위 config를 추가하면 됩니다.

# Precautions

! Config 파일은 무조건 추가 또는 덮어쓰기 하셔야됩니다.
! 시간 단위는 AWS_StartTime은 분, AWS_BroadcastTime은 초가 들어갑니다.
! 핵 이벤트 관련 이벤트가 적용되어 있는 플러그인과 함께 사용시 오류가 발생할 수 있습니다.
