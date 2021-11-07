using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OtherworldlyAcumenDivine : Template
    {
        public static readonly Guid ID = Guid.Parse("b19522b3-1309-43e8-a82b-35f07c6664a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Otherworldly Acumen - Divine",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("375229a7-9e35-4cc3-b55c-8d7f29800128"), Type = TextBlockType.Text, Text = "Choose one common 2nd-level spell from the divine tradition." };
            yield return new TextBlock { Id = Guid.Parse("3c3e7cc6-4c8d-4a9f-be4f-956f1daabdb8"), Type = TextBlockType.Text, Text = "You can cast that spell as an innate spell once per day. Your magic is adaptable. By spending 1 day of downtime, you can change the spell you chose to a different common 2nd-level spell from the same tradition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68d1cf2b-cf0c-4fa1-af30-aec629c3ef45"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
