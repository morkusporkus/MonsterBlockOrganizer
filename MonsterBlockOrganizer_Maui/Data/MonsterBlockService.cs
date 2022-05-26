using System.Text.Json;
namespace MonsterBlockOrganizer_Maui.Data;
public class MonsterBlockService
{
	public async Task<List<MonsterBlock>> GetMonsterBlocks()
	{
		var monsterBlocks = new List<MonsterBlock>();
		foreach (string file in Directory.EnumerateFiles("C:\\Data\\MonsterBlocks", "*.MONSTER"))
		{
			string contents = File.ReadAllText(file);
			MonsterBlock item = JsonSerializer.Deserialize<MonsterBlock>(contents);
			monsterBlocks.Add(item);
		}
		return monsterBlocks;
	}
}