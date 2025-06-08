using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace AncientTerraBlade.Content
{
	public class AncientsButcherer : ModItem
	{
		public override void SetDefaults() {
			Item.damage = 22;
			Item.crit = 4;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.scale = 1f;
			Item.useStyle = 1;
			Item.autoReuse = true;
			Item.knockBack = 5f;
			Item.UseSound = SoundID.Item1;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(0, 1, 35, 0);
		}
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.CrimtaneBar, 10)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}