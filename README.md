# Fanchant Practice

콘서트 셋리스트를 따라 현재 응원법을 연습하는 .NET MAUI 모바일 앱입니다.

## 현재 구현 범위

- Android 및 iOS를 포함한 .NET MAUI 프로젝트
- MVVM 기반 홈 화면
- 홈, 콘서트, 곡, 보관함 하단 내비게이션
- 공식색과 네 멤버의 디자인 색상 리소스
- SQLite 모델, 테이블 초기화, 멤버 초기 데이터
- 재생 위치에 맞는 응원 구간 탐색 서비스
- 첫 파일럿 곡 `BODY`의 출처 기반 메타데이터와 타임라인 입력 템플릿
- 반응형 Blazor WebAssembly PWA
- 웹과 MAUI에서 재사용할 Core 및 Razor 컴포넌트 프로젝트

## 프로젝트 구성

- `FanchantPractice.Core`: 공통 모델과 응원 구간 동기화 로직
- `FanchantPractice.Shared`: 웹·앱 공유 Razor 컴포넌트
- `FanchantPractice.Web`: 웹 우선 PWA
- `FanchantPractice.App`: 후속 iOS·Android용 MAUI 프로젝트

## 실행

```powershell
dotnet restore src/FanchantPractice.App/FanchantPractice.App.csproj
dotnet build src/FanchantPractice.App/FanchantPractice.App.csproj -f net10.0-android
```

웹 PWA 실행:

```powershell
dotnet run --project src/FanchantPractice.Web/FanchantPractice.Web.csproj
```

실제 음원과 공식 이미지, 공식 응원법 전문은 저장소에 포함하지 않습니다.
