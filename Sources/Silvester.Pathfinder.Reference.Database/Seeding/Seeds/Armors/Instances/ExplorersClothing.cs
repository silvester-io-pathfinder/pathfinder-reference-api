using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Armors.Instances
{
    public class ExplorersClothing : Template
    {
        public static readonly Guid ID = Guid.Parse("6fbffdfc-1443-4f6b-980b-a3d17412ac93");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Explorer's Clothing",
                ArmorClassBonus = 0,
                Price = 10,
                DexterityCap = 5,
                Strength= 0,
                CheckPenalty = 0,
                SpeedPenalty = 0,
                ArmorCategoryId = ArmorCategories.Instances.Unarmored.ID,
                ArmorGroupId = ArmorGroups.Instances.Cloth.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("915c591a-6d4e-4a6c-9ad1-8ee619a7ffd8"), Type = TextBlockType.Text, Text = "Adventurers who don’t wear armor travel in durable clothing. Though it’s not armor and uses your unarmored defense proficiency, it still has a Dex Cap and can grant an item bonus to AC if etched with potency runes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Comfort.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e4472c2-1fce-4c38-a4f0-fbca470146b3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
