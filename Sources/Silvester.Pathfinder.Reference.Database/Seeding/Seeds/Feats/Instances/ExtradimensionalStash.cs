using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExtradimensionalStash : Template
    {
        public static readonly Guid ID = Guid.Parse("9a0261d4-ef2f-436d-8d85-1ba2b164b5f7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Extradimensional Stash",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a6ece14b-7b75-4d21-9fcf-86b5cda3677f"), Type = TextBlockType.Text, Text = "When you perform sleight of hand, you fold space so that objects really do disappear. You create a small extradimensional space somewhere within in your clothing that can hold up to 5 Bulk worth of objects. The space functions as a (item: bag of holding | Bag of Holding I), but can hold only up to 5 Bulk, has no Bulk of its own, and can be (action: Interacted | Interact) with using only one hand." };
            yield return new TextBlock { Id = Guid.Parse("1b86b88e-2327-4cfc-b904-0bd8308c9815"), Type = TextBlockType.Text, Text = "In addition, when you (action: Palm an Object), you can place it directly into this extradimensional space as long as the space has sufficient free space to hold the object." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("38c1591a-2024-480b-be90-0ef2f2984f41"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("397152d8-ac53-45a7-9fa9-7c48376b00eb"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
