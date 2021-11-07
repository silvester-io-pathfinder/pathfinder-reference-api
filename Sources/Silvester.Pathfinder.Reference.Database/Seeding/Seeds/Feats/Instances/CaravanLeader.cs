using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CaravanLeader : Template
    {
        public static readonly Guid ID = Guid.Parse("c8c34620-7bca-4edb-97d2-cb9e0379fd87");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Caravan Leader",
                Level = 11,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd8c37d1-7730-440e-8ffe-88519c32b6db"), Type = TextBlockType.Text, Text = "You know how to get the most effort out of your allies on the road. When (action: Hustling | Hustle) in a group during exploration mode, your group can (action: Hustle) for as long as the member who could (action: Hustle) longest on their own, plus an additional 20 minutes beyond that." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("7869d21d-ab22-4270-a192-37ed1ed0f947"), requiredStatValue: 18, Stats.Instances.Constitution.ID);
            builder.HaveSpecificFeat(Guid.Parse("7fbb108b-d35a-4468-a08f-42e676be1573"), Feats.Instances.PickUpThePace.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7153f9e-e8c1-4b87-8f14-8efeb484e758"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
