using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Armors.Instances
{
    public class ChainShirt : Template
    {
        public static readonly Guid ID = Guid.Parse("9d419b32-9b59-4a20-9909-8485ae52f637");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Chain Shirt",
                ArmorClassBonus = 2,
                Price = 500,
                DexterityCap = 3,
                Strength = 12,
                CheckPenalty = 1,
                SpeedPenalty = 0,
                ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Chain.ID,
                BulkId = Bulks.Instances.OneBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c85e39dd-a871-4c16-8448-790b3d7c822c"), Type = TextBlockType.Text, Text = "Sometimes called a hauberk, this is a long shirt constructed of the same metal rings as chainmail. However, it is much lighter than chainmail and protects only the torso, upper arms, and upper legs of its wearer." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Flexible.ID;
            yield return Traits.Instances.Noisy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8494e18c-c37a-43ac-bf31-773ffa0195db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
