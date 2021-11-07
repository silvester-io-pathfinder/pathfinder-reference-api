using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NarrativeConduit : Template
    {
        public static readonly Guid ID = Guid.Parse("257d5057-57d7-438a-af40-18b0e0a12ac2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Narrative Conduit",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b11b304b-a571-4176-9677-a44faad95af1"), Type = TextBlockType.Text, Text = "You act as a conduit for your companions just as your stories are a conduit between teller and listener. When you Spin a Tale and the hero of your tale (action: Casts a Spell|Cast a Spell) against the villain, you warp the world, allowing the hero to calculate range and cover to the villain from your space instead of their own if they prefer. The hero must choose to calculate both range and cover from the same space; they can&#39;t use one space for range and the other for cover." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("19dd4716-3a29-40c2-8698-a16afd678016"), Feats.Instances.FolkloristDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7201f94-d8fc-4f65-ad17-82e650099da0"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
