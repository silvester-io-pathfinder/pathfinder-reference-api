using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class ChainMail : Template
    {
        public static readonly Guid ID = Guid.Parse("6c357ddd-162b-4fc0-b2a1-23ec6f1bbef4");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Chain Mail",
                ArmorClassBonus = 4,
                Price = 600,
                DexterityCap = 1,
                Strength = 16,
                CheckPenalty = 2,
                SpeedPenalty = 5,
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Chain.ID,
                BulkId = Bulks.Instances.TwoBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8513e4e9-1ea1-4da2-ad65-74830ab74d2e"), Type = TextBlockType.Text, Text = "A suit of chain mail consists of several pieces of armor composed of small metal rings linked together in a protective mesh. It typically includes a chain shirt, leggings, a pair of arms, and a coif, collectively protecting most of the body." };
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
                Id = Guid.Parse("cafddd9f-fffa-447f-af6b-759154d33281"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
