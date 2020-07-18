using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ExampleMod.Content.Items.Placeable.Furniture
{
	public class ExampleBed : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded bed.");
		}

		public override void SetDefaults() {
			item.width = 28;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.Swing;
			item.consumable = true;
			item.value = 2000;
			item.createTile = TileType<Tiles.Furniture.ExampleBed>();
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Bed)
				.AddIngredient<ExampleBlock>(10)
				.AddTile<Tiles.Furniture.ExampleWorkbench>()
				.Register();
		}
	}
}