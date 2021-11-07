using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedStratagem : Template
    {
        public static readonly Guid ID = Guid.Parse("23aa4a29-a6c2-41ff-9e08-254f901c05a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Stratagem",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0eb617bc-8dd4-4784-9d6a-7c1af83829bf"), Type = TextBlockType.Text, Text = "The plans you make include your allies as well as yourself. When you hit a creature with an attack on which you substituted your attack roll due to (feat: Devising a Stratagem | Devise a Stratagem), designate one ally. The creature you hit is flat-footed to that ally on the next attack the designated ally makes against that creature before the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06cbeb75-bfc2-4f69-a0fd-e8dbbdaf3d6c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
