# GFBattleSimulatorUI
Girls' Frontline battle simulator UI supporter It's not provide simulation fuction

# Dependence
* [GFBattleSimulator](https://gall.dcinside.com/mgallery/board/view/?id=micateam&no=1506585&search_pos=-1502934&s_type=search_name&s_keyword=es&page=1)

* .NET framework

# How to use?
It support just edit json data file to simulate, you should install GFBattleSimulator from above link and move builded application and resource at that directory.

# Fuction

Now it's on dev, maybe some functions are not support. but it will be added soon.

1. Edit and read squad, fairy, HOC, equipment data and save all of them
2. Save and road preset to/from other directory
3. calculate doll stat by Level and favor

# Bugs

1. doll select page have alittle memory leak
2. fairy level text cut off if you don't have text font
3. Exclusion processing are not added for all file IO. so sometimes it doesn't work if use wrong data file

----------------------
## 한국어

# GFBattleSimulatorUI
해당 프로젝트는 시뮬레이터의 UI를 제공합니다. 시뮬레이션 기능은 포함되지 않았습니다.

# 필요 요소

 * [소녀전선 전투 시뮬레이터](https://gall.dcinside.com/mgallery/board/view/?id=micateam&no=1506585&search_pos=-1502934&s_type=search_name&s_keyword=es&page=1)
 * .NET 프레임워크

# 사용방법

해당 프로그램은 json 데이터 파일을 더욱 편하게 편집하기 위해서 제작되었습니다. 따라서 위 링크에서 GFBattleSimulator을 받으신 후 설치된 파일에 빌드된 해당 응용프로그램과 리소스 파일을 넣어주셔야 합니다.

# 기능

아직 개발중이라 일부 기능들이 지원되지 않을 수 있습니다. 곧 추가되니 기대해주세요.

1. 제대정보, 장비정보, 요정정보, 화력소대정보, 칩정보 편집 및 저장
2. 프리셋 파일을 불러오거나, 다른 경로로 저장할 수 있습니다.
3. 레벨과 호감도에 따른 인형 능력치를 계산합니다.

# 버그
 1. 인형선택 창에서 약간의 메모리누수가 발생합니다.
 2. 폰트가 설치되지 않았을 시 요정의 레벨텍스트가 잘려서 출력됩니다.
 3. 아직 에러테스트를 빡세게 진행하지 않았습니다. 잘못된 데이터파일을 사용 시 제외처리가 되지 않을 수 있습니다.