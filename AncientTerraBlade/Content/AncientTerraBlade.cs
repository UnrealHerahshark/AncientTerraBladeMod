using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using AncientTerraBlade;
using AncientTerraBlade.Content;

namespace AncientTerraBlade.Content
{
	public class AncientTerraBlade : ModItem
	{
		public override void SetDefaults()
		{
			base.Item.damage = 115;
			base.Item.crit = 4;
			base.Item.DamageType = DamageClass.Melee;
			base.Item.useTime = 14;
			base.Item.useAnimation = 14;
			base.Item.scale = 1f;
			base.Item.useStyle = 1;
			base.Item.autoReuse = true;
			base.Item.knockBack = 6.5f;
			base.Item.UseSound = new SoundStyle?(SoundID.Item60);
			base.Item.shoot = 132;
			base.Item.shootSpeed = 12f;
			base.Item.rare = 7;
			Item.value = Item.buyPrice(1, 0, 0, 0);
		}
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<TrueAncientsEdge>()
				.AddIngredient<TrueAncientExcalibur>()
				.AddIngredient(ItemID.BrokenHeroSword)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
