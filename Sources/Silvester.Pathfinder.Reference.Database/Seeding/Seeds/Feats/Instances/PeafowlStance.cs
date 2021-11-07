using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PeafowlStance : Template
    {
        public static readonly Guid ID = Guid.Parse("18189260-3af0-404e-80e9-810146fb796a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Peafowl Stance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a4b077f-7c5e-4c08-8a53-f4971975441b"), Type = TextBlockType.Text, Text = "You enter a tall and proud stance while remaining mobile, with all the grace and composure of a peafowl. While in this stance, the only (action: Strikes | Strike) you can make are melee (action: Strikes | Strike) with the required sword. Once per round, after you hit with a monk sword (action: Strike), you can (action: Step) as a free action as your next action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2d8637f6-e3ee-41c4-b919-dc79f8e56736"), Feats.Instances.MonasticWeaponry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d10c6ebd-892c-4d18-a3e4-81d7c2f381e9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
