using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using tsorcRevamp.Projectiles;

namespace tsorcRevamp.Items.Weapons
{
    public class EnchantedThrowingSpear : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Magic throwing spear that passes through walls and is created with mana on each throw");
        }
        public override void SetDefaults()
        {
            item.shootSpeed = 12f;
            item.damage = 39;
            item.knockBack = 9f;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 15;
            item.useTime = 15;
            item.width = 64;
            item.height = 64;
            item.maxStack = 1;
            item.rare = ItemRarityID.LightRed;

            item.consumable = false;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.thrown = true;

            item.UseSound = SoundID.Item1;
            item.value = 100000;
            //item.shoot = ModContent.ProjectileType<Projectiles.DragoonLance>();
            item.shoot = ModContent.ProjectileType<Projectiles.EnchantedThrowingSpear>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            //recipe.AddIngredient(mod.GetItem("ThrowingSpear"), 1);
            recipe.AddIngredient(ItemID.SoulofLight, 3);
            //recipe.AddIngredient(mod.GetItem("EphemeralDust"), 30);
            recipe.AddIngredient(mod.GetItem("DarkSoul"), 5000);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.AddRecipe();
        }
    }
}
