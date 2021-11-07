using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StageFighting : Template
    {
        public static readonly Guid ID = Guid.Parse("18ce2c10-520d-49f0-bbeb-968b4731c36e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stage Fighting",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("341a1e08-345d-4ac3-8b61-c6a62cc8f7c4"), Type = TextBlockType.Text, Text = "You pull punches to give a better show. You don’t take the usual -2 circumstance penalty when making a nonlethal attack with a weapon or unarmed attack that doesn’t have the (trait: nonlethal) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e9ae9cd0-cf7b-46a4-971f-3cb138bb8e21"), Feats.Instances.GladiatorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc897c0d-e397-42d5-8485-d40730243058"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
