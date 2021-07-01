using System.ComponentModel;
using Exiled.API.Interfaces;

namespace YouTubeTutorialPlugin
{
	public sealed class Config : IConfig
	{

		[Description("Determines if the plugin should be enabled or disabled.")]
        public bool IsEnabled { get; set; } = true;

		[Description("INOP. Player Joined Massges ")]
        public static string fallchJoinMassge { get; set; } = "현재 문 도박 플러그인 베타테스트중 입니다. 버그는 갱생 풀치#6696 에게 제보 부탁합니다";

		


	}
}