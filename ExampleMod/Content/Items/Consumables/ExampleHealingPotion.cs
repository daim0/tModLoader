﻿using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ExampleMod.Content.Items.Consumables
{
	public class ExampleHealingPotion : ModItem
	{
		public override void SetDefaults() {
			item.width = 20;
			item.height = 26;
			item.useStyle = ItemUseStyleID.EatFood;
			item.useAnimation = 17;
			item.useTime = 17;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.consumable = true;
			item.rare = ItemRarityID.Orange;
			item.value = Item.buyPrice(gold: 1);

			item.healLife = 100; // While we change the actual healing value in GetHealLife, item.healLife still needs to be higher than 0 for the item to be considered a healing item
			item.potion = true; // Makes it so this item applies potion sickness on use and allows it to be used with quick heal
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips) {
			// Find the tooltip line that corresponds to 'Heals ... life'
			// See https://tmodloader.github.io/tModLoader/html/class_terraria_1_1_mod_loader_1_1_tooltip_line.html for a list of vanilla tooltip line names
			TooltipLine line = tooltips.FirstOrDefault(x => x.mod == "Terraria" && x.Name == "HealLife");
			if (line != null) {
				// Change the text to 'Heals max/2 (max/4 when quick healing) life'
				line.text = Language.GetTextValue("CommonItemTooltip.RestoresLife", $"{Main.LocalPlayer.statLifeMax2 / 2} ({Main.LocalPlayer.statLifeMax2 / 4} when quick healing)");
			}
		}

		public override void GetHealLife(Player player, bool quickHeal, ref int healValue) {
			// Make the item heal half the player's max health normally, or one fourth if used with quick heal
			healValue = player.statLifeMax2 / (quickHeal ? 4 : 2);
		}

		//Please see ExampleItem.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<ExampleItem>(10)
				.AddTile(TileID.Bottles) //Making this recipe be crafted at bottles will automatically make Alchemy Table's effect apply to its ingredients.
				.Register();
		}
	}
}