using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterAnimalSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("d3f5ccdf-56ae-4a5f-865d-8e4f85491fc8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Animal Senses",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times, either choosing a different sense or improving an imprecise sense granted by this feat to a precise sense.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("238ba0f6-be6e-449f-a531-ba05f005cfb2"), Type = TextBlockType.Text, Text = "Your senses advance to match those of your animal aspect. You gain one of the following senses available to your inherent animal: echolocation (imprecise) 30 feet or tremorsense (imprecise) 30 feet. If your inherent animal doesn’t typically have a specific type of sense, you can’t gain the sense with this feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6fe4ad3e-fe43-46ae-9b48-a81efda14bd4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
