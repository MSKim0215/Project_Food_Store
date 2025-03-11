# 📌 디노버거
>요리 & 시뮬레이션 게임  
>게임 이미지 스크린샷  
>https://youtube.co.kr (시연 영상)

</br>

## 1. 제작 기간 & 참여 인원
- 2025년 01월 09일 ~ 02월 27일
- 개인 프로젝트

</br>

## 2. 사용 기술
#### `Client`
- Unity6

</br>

## 3. 클래스 구조 설계

## 4. 핵심 기능
이 게임의 목표는 손님이 주문한 음식을 요리하여 최대한 많은 손님을 만족하게 만드는 것을 목표로 합니다.
사용자는 햄버거에 들어가는 토핑을 확인하고, 해당되는 토핑을 손질하고 넣어서 만들 수 있습니다.
토핑의 종류에 따라 조리 방식이 다릅니다.

<details>
<summary><b>핵심 기능 설명 펼치기</b></summary>
<div markdown="1">

### 4.1. 전체 흐름
이미지 첨부

- **기능** 📌 [코드 확인]()
  - 기능 설명

### 4.2. NPC Spawn
![Guest Spawner](https://github.com/user-attachments/assets/48a913c4-0c12-4b61-89e0-12c53683303f)

- **Spawner 초기화** 📌 [코드 확인](https://github.com/MSKim0215/Dino_Burger/blob/26f141d32664c3031c122082ff2f87f32028f7fd/Assets/Scripts/Manager/Game/GuestManager.cs#L15)
  - 게임이 시작되면 미리 설정된 좌표를 불러와 생성 좌표를 초기화합니다.

- **NPC 생성** 📌 [코드 확인](https://github.com/MSKim0215/Dino_Burger/blob/26f141d32664c3031c122082ff2f87f32028f7fd/Assets/Scripts/Manager/Game/GuestManager.cs#L142)
  - 일정 시간마다 지정된 좌표에 NPC를 생성합니다.
  - 생성은 오브젝트 풀 매니저를 통해 이루어집니다.
 
- **NPC 종류**
  - Car와 Guest로 구성되어 있으며, 각각 해당 Spawner와 Manager가 관리합니다.

### 4.3. NPC Controller

### 4.4. Player Controller

### 4.5. Food Controller

</div>
</details>

</br>

## 5. 핵심 트러블 슈팅
### 5.1. 예시 문제 이름
- 처음에 어떤 방식으로 구현했는지, 왜 그것을 사용했는지 이유를 적는다.

- 하지만 그로 인해 발생한 or 어떠한 이유로 인해 더 효율적인 것이 있다는 것을 알게 되어서 개선하려고 한다.

- 그런데 그렇게 되면 현재 구조와는 맞지 않기 때문에 구조 개선을 필요로 하게 된다.

<details>
<summary><b>기존 코드</b></summary>
<div markdown="1">

~~~c#
// example code
~~~

</div>
</details>

- 이 때 어떤 행동을 하면, 무슨 문제가 발생하기 때문에
- 아래 **개선된 코드** 와 같이 무엇을 사용해서 개선할 수 있었다.

<details>
<summary><b>개선된 코드</b></summary>
<div markdown="1">

~~~c#
// example code
~~~

</div>
</details>

</br>

## 6. 그 외 트러블 슈팅
<details>
<summary>예시 오류</summary>
<div markdown="1">

- 어떤 방식으로 해결함
- 참고 링크 이미지 등 첨부하면 좋을듯
- 오류 문구 첨부도 좋고
- 코드가 필요한 경우 추가

</div>
</details>

</br>

## 7. 회고 / 느낀점
> 필요하다면 추가
