# Architecture

화면은 View와 ViewModel로 분리하고, 기능은 Service, 저장소 접근은 Repository 계층에서 처리합니다.

```text
View → ViewModel → Service → Repository → SQLite
```

MVP는 곡마다 현재 응원법 하나만 제공합니다. 이전 멤버 구성과 과거 응원법 선택 기능은 포함하지 않습니다.
