using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArchersAim : Template
    {
        public static readonly Guid ID = Guid.Parse("0ef1a298-a5bd-49d9-88ba-c9d4f9881607");

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
            yield return new TextBlock { Id = Guid.Parse("5e0471bc-8a1f-4100-80f6-7152a9605a80"), Type = TextBlockType.Text, Text = "You slow down, focus, and take a careful shot. Make a ranged (action: Strike) with a weapon in the bow weapon group. You gain a +2 circumstance bonus to the attack roll and ignore the target’s concealed condition. If the target is hidden, reduce the flat check from being hidden from 11 to 5." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("af3084e3-0c75-4e58-9258-fe82eaa6371e"), Feats.Instances.ArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8072a2d1-955d-4f3a-a072-94c040ae0b38"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
