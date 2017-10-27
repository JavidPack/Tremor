using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NorthHammer : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 8;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 20;
			item.useAnimation = 20;
			item.hammer = 40;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 100;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("North Hammer");
			Tooltip.SetDefault("");
		}

	}
}
