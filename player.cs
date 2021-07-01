using Exiled.Events.EventArgs;
using System;
using Exiled.API.Features;
using Interactables.Interobjects.DoorUtils;
using System.Threading;
using System.Threading.Tasks;
using Exiled.Events.Handlers;
using Exiled.API.Enums;
using Exiled.Events.Extensions;
using Mirror;
using System.Windows.Forms;
using Exiled;






namespace fallchPluginLockedDoor.Handlers
{
    internal class player
	{
		//bataTest msg
		public static void OnplayerJoined(JoinedEventArgs ev)
		{
		   ev.Player.Broadcast(5, $"현재 문 도박 플러그인 베타테스트중 입니다. 버그는 갱생 풀치#6696 에게 제보 부탁합니다");
		}

		public static void OnInteractingDoor(InteractingDoorEventArgs ev)
		{
			
			{
				
				Thread.Sleep(10);

				//PlayerClass = SCP
				if (ev.Player.Role == RoleType.Scp049 || ev.Player.Role == RoleType.Scp173 || ev.Player.Role == RoleType.Scp0492 || ev.Player.Role == RoleType.Scp096 || ev.Player.Role == RoleType.Scp106 || ev.Player.Role == RoleType.Scp173 || ev.Player.Role == RoleType.Scp93953 || ev.Player.Role == RoleType.Scp93989)
				{
					if (ev.IsAllowed == false && ev.Player.IsBypassModeEnabled == false && ev.Door.RequiredPermissions.RequiredPermissions != KeycardPermissions.None && ev.Door.RequiredPermissions.RequiredPermissions != KeycardPermissions.ScpOverride && ev.Door.RequiredPermissions.RequiredPermissions != KeycardPermissions.Checkpoints)

					{

				
						
						System.Random rnd = new Random();
						
						int fallchDoorVal = rnd.Next(1, 101);
						//출처: https://bemeal2.tistory.com/33 [헝그리개발자]

						Thread.Sleep(1);
						if (fallchDoorVal >= 95 && ev.IsAllowed == false)
						{
							ev.Door.ActiveLocks = 0;
							ev.IsAllowed = true;
							ev.Player.Broadcast(duration: 5, "운이 좋으시군요 문을 열어 드렸습니다");





						}

						if (fallchDoorVal <= 5 && ev.IsAllowed == false)
						{
							ev.Player.Hurt(1000);
							ev.Player.Broadcast(duration: 5, "당신은 문도박 플러그인에 의하여 1000피해를 입었습니다");

						}





					}
				}

				else
				{
					//PlayerClass = NORM
					Thread.Sleep(1);
					if (ev.IsAllowed == false && ev.Door.RequiredPermissions.RequiredPermissions != KeycardPermissions.None)
					{

						System.Random rnd = new Random();

						int fallchDoorVal = rnd.Next(1, 101);
						//출처: https://bemeal2.tistory.com/33 [헝그리개발자]


						if (fallchDoorVal >= 80 && ev.IsAllowed == false)
						{
							ev.Door.ActiveLocks = 0;
							ev.IsAllowed = true;
							ev.Player.Broadcast(duration: 5, "운이 좋으시군요 문을 열어 드렸습니다");


						}

						if (fallchDoorVal <= 15 && ev.IsAllowed == false)
						{
							ev.Player.Kill(DamageTypes.Lure);
							ev.Player.Broadcast(duration: 5, "당신은 문도박 플러그인에 의하여 사망하였습니다");



						}


					}
					

				}




			}
		}
	}
}