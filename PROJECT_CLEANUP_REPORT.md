# ShootingGame_SO 정리 리포트

## 정리 기준

- 원본 프로젝트는 수정하지 않았습니다.
- Unity 자동 생성 파일과 개인 설정 파일을 제거했습니다.
- Unity `.meta` 파일은 이동 대상과 함께 보존했습니다.
- 스크립트, 프리팹, 씬 참조는 GUID 기반이므로 폴더 이동 후에도 참조가 유지되도록 구성했습니다.

## 제거한 항목

- `.vs/`
- `obj/`
- `UserSettings/`
- `*.csproj`
- `*.sln`
- IDE/OS 임시 파일

## 주요 폴더 변경

| 기존 위치 | 새 위치 |
|---|---|
| `Assets/Scenes` | `Assets/_Project/Scenes` |
| `Assets/Prefabs` | `Assets/_Project/Prefabs` |
| `Assets/Metrial` | `Assets/_Project/Materials` |
| `Assets/Resouces` | `Assets/_Project/Resources` |
| `Assets/SO` | `Assets/_Project/ScriptableObjects` |
| `Assets/Scripts` | `Assets/_Project/Scripts` |
| `Assets/streamingAssets` | `Assets/StreamingAssets` |
| `Assets/AssetDown/...` | `Assets/_ThirdParty/...` 또는 `Assets/_Project/Audio/SFX/...` |
| `Assets/TextMesh Pro` | `Assets/_ThirdParty/TextMesh Pro` |

## 새 구조

```text
Assets/
  _Project/
    Audio/
      Mixers/
      SFX/
    Materials/
    Prefabs/
    RenderTextures/
    Resources/
    Scenes/
    ScriptableObjects/
    Scripts/
  _ThirdParty/
    AwesomeCartoonPlanes/
    CartoonFXRemaster/
    StarfieldMaterials/
    TextMesh Pro/
  StreamingAssets/
Packages/
ProjectSettings/
```

## 프로젝트 설정 정리

- `ProjectSettings/EditorBuildSettings.asset`에 `Assets/_Project/Scenes/GameScene.unity`를 빌드 씬으로 등록했습니다.
- `ProjectSettings/ProjectSettings.asset`의 기본 템플릿 씬 경로를 `Assets/_Project/Scenes/GameScene.unity`로 갱신했습니다.
- `.gitignore`를 추가해 Unity 캐시, IDE 파일, OS 임시 파일이 다시 섞이지 않도록 했습니다.

## 추가 권장 수정

- `Charctor*`, `MonsterManger`, `Metrial`, `Resouces`처럼 오타가 있는 이름은 코드/클래스명까지 함께 정리하면 좋습니다. 이번 정리는 Unity 참조 안전성을 위해 파일명과 클래스명은 변경하지 않았습니다.
- `BulletControl.Update()`에서 매 프레임 `Invoke("bulletDestory", 5f)`가 호출됩니다. 총알이 활성화될 때 1회만 예약하는 방식으로 바꾸는 것이 좋습니다.
- 테스트용으로 보이는 `ArrayTest`, `PropertyTest`, `StaticTest`, `classSA`는 `Assets/_Project/Scripts/Samples`로 이동했습니다. 실제 빌드에서 필요 없으면 제거 후보입니다.
- `Packages/manifest.json`의 IDE/테스트/Visual Scripting 패키지는 실제 사용 여부에 따라 줄일 수 있습니다. 이번 작업에서는 빌드 안정성을 위해 유지했습니다.

## 용량

- 원본 추출 크기: 111.0 MB
- 정리본 추출 크기: 97.9 MB
