using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class CreepyThrone : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 48;
			item.height = 64;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
			item.createTile = mod.TileType("CreepyThrone");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Creepy Throne");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 25);
			recipe.AddIngredient(null, "MinotaurHorn", 2);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 25);
			recipe.AddIngredient(null, "MinotaurHorn", 2);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}
