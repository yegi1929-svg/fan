# Fanchant Practice

콘서트 셋리스트를 따라 현재 응원법을 연습하는 .NET MAUI 모바일 앱입니다.

## 현재 구현 범위

- Android 및 iOS를 포함한 .NET MAUI 프로젝트
- MVVM 기반 홈 화면
- 홈, 콘서트, 곡, 보관함 하단 내비게이션
- 공식색과 네 멤버의 디자인 색상 리소스
- SQLite 모델, 테이블 초기화, 멤버 초기 데이터
- 재생 위치에 맞는 응원 구간 탐색 서비스

## 실행

```powershell
dotnet restore src/FanchantPractice.App/FanchantPractice.App.csproj
dotnet build src/FanchantPractice.App/FanchantPractice.App.csproj -f net10.0-android
```

실제 음원과 공식 이미지, 공식 응원법 전문은 저장소에 포함하지 않습니다.
