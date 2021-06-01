using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterials.Instances
{
    public class Darkwood : Template
    {
        public static readonly Guid ID = Guid.Parse("46176cae-7909-40a1-964a-2a4959dbc099");

        protected override PreciousMaterial GetMaterial()
        {
            return new PreciousMaterial
            {
                Id = ID,
                Name = "Darkwood",
                ShieldId = PreciousMaterialShields.Instances.DarkwoodShield.ID,
                WeaponId = PreciousMaterialWeapons.Instances.DarkwoodWeapon.ID,
                ArmorId = PreciousMaterialArmors.Instances.DarkwoodArmor.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f4e2ec82-b861-440f-a478-7cd743c3d640"), Type = TextBlockType.Text, Text = "Darkwood is a very lightweight wood found primarily in old-growth forests in south-central Avistan; it is dark as ebony but has a slight purple tint. A darkwood item’s Bulk is reduced by 1 (or to light Bulk if its normal Bulk is 1, with no effect on an item that normally has light Bulk). The Price of an item made of darkwood is based on the item’s normal Bulk, not its reduced Bulk for being made of darkwood, but reduce the Bulk before making any further Bulk adjustments for the size of the item." };
        }

        protected override IEnumerable<PreciousMaterialItem> GetItems()
        {
            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("9ed0f9d7-2a8c-480d-885f-19ad636c3b37"),
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("35968707-549c-4279-91a4-55d7db6a65d1"),
                Hardness = 8,
                HitPoints = 32,
                BrokenThreshold = 16,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("3e02e038-df2c-4a60-aaba-7f344735e659"),
                Hardness = 7,
                HitPoints = 28,
                BrokenThreshold = 14,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("7b25775d-f4c0-44c8-96f4-6fe80de6ed70"),
                Hardness = 10,
                HitPoints = 40,
                BrokenThreshold = 20,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("f5251c9f-97b3-4850-a2a4-e413da6eb3a3"),
                Hardness = 14,
                HitPoints = 56,
                BrokenThreshold = 28,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("6bf886e7-6386-477a-a1e6-8f1872f149bb"),
                Hardness = 20,
                HitPoints = 80,
                BrokenThreshold = 40,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };
        }

        protected override IEnumerable<PreciousMaterialVariant> GetVariants()
        {
            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("81aaa9dc-86cb-47ef-a4fa-30f8287b03ee"),
                Name = "Darkwood Branch",
                BulkId = Bulks.Instances.LightBulk.ID,
                ItemLevel = 0,
                Price = 50000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("563092d5-6ee1-4d5a-b5d2-3edd781d4f71"),
                Name = "Darkwood Lumber",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 0,
                Price = 500000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("78a7e5c4-afc2-4523-97f3-05703e296466"),
                Name = "Darkwood Object",
                NameAddendum = "Standard Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 8,
                Price = 35000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("5e3d48a5-7c71-4aea-92bb-6c08099fe5eb"),
                Name = "Darkwood Object",
                NameAddendum = "High Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 16,
                Price = 600000
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Precious.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0048bf82-fbd4-4b14-90f9-ffdd136008e1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 578
            };
        }
    }
}
