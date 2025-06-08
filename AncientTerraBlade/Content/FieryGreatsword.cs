using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientTerraBlade.Content
{
	public class FieryGreatsword : ModItem
	{
		public override void SetDefaults() {
			Item.damage = 40;
			Item.crit = 4;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.scale = 1f;
			Item.useStyle = 1;
			Item.autoReuse = true;
			Item.knockBack = 6.5f;
			Item.UseSound = SoundID.Item1;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.buyPrice(0, 20, 0, 0);
		}
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.HellstoneBar, 20)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}