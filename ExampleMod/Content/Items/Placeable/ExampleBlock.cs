﻿using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ExampleMod.Content.Items.Placeable
{
	public class ExampleBlock : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded block.");
			ItemID.Sets.ExtractinatorMode[item.type] = item.type;

			// Some please convert this to lang files, I'm too lazy to do it

			// DisplayName.AddTranslation(GameCulture.German, "Beispielblock");
			// Tooltip.AddTranslation(GameCulture.German, "Dies ist ein modded Block");
			// DisplayName.AddTranslation(GameCulture.Italian, "Blocco di esempio");
			// Tooltip.AddTranslation(GameCulture.Italian, "Questo è un blocco moddato");
			// DisplayName.AddTranslation(GameCulture.French, "Bloc d'exemple");
			// Tooltip.AddTranslation(GameCulture.French, "C'est un bloc modgé");
			// DisplayName.AddTranslation(GameCulture.Spanish, "Bloque de ejemplo");
			// Tooltip.AddTranslation(GameCulture.Spanish, "Este es un bloque modded");
			// DisplayName.AddTranslation(GameCulture.Russian, "Блок примера");
			// Tooltip.AddTranslation(GameCulture.Russian, "Это модифицированный блок");
			// DisplayName.AddTranslation(GameCulture.Chinese, "例子块");
			// Tooltip.AddTranslation(GameCulture.Chinese, "这是一个修改块");
			// DisplayName.AddTranslation(GameCulture.Portuguese, "Bloco de exemplo");
			// Tooltip.AddTranslation(GameCulture.Portuguese, "Este é um bloco modded");
			// DisplayName.AddTranslation(GameCulture.Polish, "Przykładowy blok");
			// Tooltip.AddTranslation(GameCulture.Polish, "Jest to modded blok");
		}

		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.Swing;
			item.consumable = true;
			item.createTile = TileType<Tiles.ExampleBlock>();
		}

		public override void AddRecipes() {
			CreateRecipe(10)
				.AddIngredient<ExampleItem>()
				.Register();

			// CreateRecipe()
			// 	.AddIngredient<ExampleWall>(4)
			// 	.Register();

			// CreateRecipe()
			// 	.AddIngredient<ExamplePlatform>(2)
			// 	.Register();
		}

		// todo: implement
		// public override void ExtractinatorUse(ref int resultType, ref int resultStack) {
		// 	if (Main.rand.NextBool(30)) {
		// 		resultType = ItemType<FoulOrb>();
		// 		if (Main.rand.NextBool(5)) {
		// 			resultStack += Main.rand.Next(2);
		// 		}
		// 	}
		// }
	}
}