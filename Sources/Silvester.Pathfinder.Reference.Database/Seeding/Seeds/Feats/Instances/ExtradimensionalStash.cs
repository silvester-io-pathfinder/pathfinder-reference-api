using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExtradimensionalStash : Template
    {
        public static readonly Guid ID = Guid.Parse("f52c7960-b36d-40f2-903f-a6bec821dc91");

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
            yield return new TextBlock { Id = Guid.Parse("2b8f0701-18d9-4582-825a-d812a61eef72"), Type = TextBlockType.Text, Text = "When you perform sleight of hand, you fold space so that objects really do disappear. You create a small extradimensional space somewhere within in your clothing that can hold up to 5 Bulk worth of objects. The space functions as a (item: bag of holding | Bag of Holding I), but can hold only up to 5 Bulk, has no Bulk of its own, and can be (action: Interacted | Interact) with using only one hand." };
            yield return new TextBlock { Id = Guid.Parse("dbf1a609-e576-484e-a179-546c9cff8fa3"), Type = TextBlockType.Text, Text = "In addition, when you (action: Palm an Object), you can place it directly into this extradimensional space as long as the space has sufficient free space to hold the object." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f29605ad-3b67-4cec-a0cc-261ca1b8844e"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40ae8e6b-6b65-4779-989c-363a48b8980c"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
