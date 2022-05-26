using Microsoft.AspNetCore.Components;
using MonsterBlockOrganizer_Maui.Data;
using System.Linq;
namespace MonsterBlockOrganizer_Maui.Pages;
public partial class MonsterBlocks
{
	[Inject]
	private MonsterBlockService MonsterBlockService { get; set; }
	private List<MonsterBlock> monsterBlocks = new List<MonsterBlock>();
	private MonsterBlock selectedBlock = new MonsterBlock();
	protected override async Task OnInitializedAsync()
	{
		monsterBlocks = await MonsterBlockService.GetMonsterBlocks();
	}
	private void GetDetail(string name)
	{
		selectedBlock = monsterBlocks.First(f => f.name == name);
	}

}