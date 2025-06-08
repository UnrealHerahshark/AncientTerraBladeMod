using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientTerraBlade.Content
{
	public class AncientBladeofGrass : ModItem
	{
		public override void SetDefaults() {
			Item.damage = 28;
			Item.crit = 4;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.scale = 1f;
			Item.useStyle = 1;
			Item.autoReuse = true;
			Item.knockBack = 3f;
			Item.UseSound = SoundID.Item1;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.buyPrice(0, 2, 70, 0);
		}
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.JungleSpores, 12)
				.AddIngredient(ItemID.Stinger, 12)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}