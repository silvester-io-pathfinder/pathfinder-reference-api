using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PivotStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("e3552361-e020-4ee5-9e1f-afa9a7648315");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pivot Strike",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dcb6f04e-0883-4b67-a928-6827f3af390b"), Type = TextBlockType.Text, Text = "You (action: Leap) and then (action: Strike) using your staff. You gain a circumstance bonus to damage for the (action: Strike) equal to twice the number of weapon damage dice. Regardless of whether your (action: Strike) hit, you can then attempt to (action: Shove) or (action: Trip) the target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dd343d1e-dc4f-460c-b6e7-ff5750fd558f"), Feats.Instances.StaffAcrobatDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd7fe375-ae8a-40b0-aa8c-f5ef90cd01a4"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
