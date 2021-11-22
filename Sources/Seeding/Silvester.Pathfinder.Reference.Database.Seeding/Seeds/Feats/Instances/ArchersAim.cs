using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArchersAim : Template
    {
        public static readonly Guid ID = Guid.Parse("b9de7bde-cfcb-4046-94e4-24be7c946fff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Archer's Aim",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e597cfbb-fdff-4a7c-8bd9-66d9fcdf55ae"), Type = TextBlockType.Text, Text = "You slow down, focus, and take a careful shot. Make a ranged (action: Strike) with a weapon in the bow weapon group. You gain a +2 circumstance bonus to the attack roll and ignore the target's concealed condition. If the target is hidden, reduce the flat check from being hidden from 11 to 5." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ffbb1384-2ec0-4007-8aaa-a433770d7353"), Feats.Instances.ArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("611111de-375a-4a1f-9e7b-d7d393956f61"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
