﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using tsorcRevamp.Projectiles;

namespace tsorcRevamp.Items.Weapons
{
    public class HiRyuuSpear : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HiRyuu Spear");
        }

        public override void SetDefaults()
        {
            item.damage = 78;
            item.knockBack = 7f;

            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useAnimation = 15;
            item.useTime = 5;
            item.shootSpeed = 5;
            //item.shoot = ProjectileID.DarkLance;

            item.height = 50;
            item.width = 50;

            item.melee = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.value = 430000;
            item.rare = ItemRarityID.Pink;
            item.maxStack = 1;
            item.UseSound = SoundID.Item1;
            item.shoot = ModContent.ProjectileType<Projectiles.HiRyuuSpear>();

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteGlaive);
            recipe.AddIngredient(mod.GetItem("DarkSoul"), 45000);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.AddRecipe();
        }
    }
}
