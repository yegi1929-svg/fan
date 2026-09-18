# BODY 파일럿 데이터

## 확인된 정보

- 아티스트: HIGHLIGHT
- 곡: BODY
- 앨범: Switch On
- 발매일: 2024-03-11
- 공식 응원법 공개일: 2024-03-12
- 공식 공지: https://www.aroundusent.com/staffNotice/detail/68?category_idx=&page=1
- 공식 응원법 영상: https://www.youtube.com/watch?v=6QKiHlFB5jE
- 공식 뮤직비디오: https://www.youtube.com/watch?v=olPe8g7A32E

## 데이터 입력 원칙

음원, 영상, 가사와 공식 응원법 전문은 저장소에 포함하지 않는다. 사용자가 합법적으로 보유한 로컬 음원을 앱에서 선택하고, `body-segments.template.csv`에는 필요한 응원 구간의 시작·종료 시간과 짧은 구호만 입력한다.

공식 응원법 영상과 로컬 음원은 전주 및 편집 길이가 다를 수 있으므로, 최종 밀리초 값은 앱에서 로컬 음원을 재생하며 보정한다.

## 다음 검수 단계

1. 공식 응원법 영상을 기준으로 구간 유형을 분류한다.
2. 로컬 음원에서 각 구간의 시작·종료 시간을 기록한다.
3. 멤버 이름 구간은 MemberId와 연결한다.
4. 반복 재생으로 경계를 보정한다.
5. 검수가 끝나면 VerificationStatus를 Verified로 변경한다.
