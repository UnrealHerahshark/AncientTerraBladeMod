using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using AncientTerraBlade;
using AncientTerraBlade.Content;

namespace AncientTerraBlade.Content
{
	public class TrueAncientsEdge : ModItem
	{
		public override void SetDefaults() {
			Item.damage = 105;
			Item.crit = 4;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 26;
			Item.useAnimation = 26;
			Item.scale = 1f;
			Item.useStyle = 1;
			Item.autoReuse = true;
			Item.knockBack = 4.75f;
			Item.UseSound = SoundID.Item1;
			Item.shoot = 157;
			Item.shootSpeed = 12f;
			Item.rare = ItemRarityID.Yellow;
			Item.value = Item.buyPrice(0, 50, 0, 0);
		}
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<AncientsEdge>()
				.AddIngredient(ItemID.SoulofFright, 20)
				.AddIngredient(ItemID.SoulofMight, 20)
				.AddIngredient(ItemID.SoulofSight, 20)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}