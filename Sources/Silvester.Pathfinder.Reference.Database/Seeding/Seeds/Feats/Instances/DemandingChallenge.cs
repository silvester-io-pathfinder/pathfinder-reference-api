using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DemandingChallenge : Template
    {
        public static readonly Guid ID = Guid.Parse("3e54e98a-971e-47b8-9b81-9560be765469");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demanding Challenge",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4545dbdf-2d6e-4c61-ba73-3c67e532df83"), Type = TextBlockType.Text, Text = "If your skill check to challenge a foe is a success, the target of your challenge takes a -1 circumstance penalty to attack rolls (or -2 if you critically succeed) until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bf280ad0-d142-4eb2-9629-bacc135ab379"), Feats.Instances.BoastersChallenge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e9d0666-d259-4654-86df-81586017a58e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
