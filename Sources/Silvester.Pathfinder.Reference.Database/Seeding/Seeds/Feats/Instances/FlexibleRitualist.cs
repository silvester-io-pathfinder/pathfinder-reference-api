using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlexibleRitualist : Template
    {
        public static readonly Guid ID = Guid.Parse("d037ea3a-1618-4061-8b6c-522403f96c04");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flexible Ritualist",
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
            yield return new TextBlock { Id = Guid.Parse("c746b1bd-b410-4fa2-9d1e-c0124e4e7918"), Type = TextBlockType.Text, Text = "You can perform two aspects of a ritual yourself. When you cast a ritual, you can reduce the number of secondary casters by 1. When you do, you must fulfill any requirements for the secondary caster, and you attempt the secondary check normally performed by that secondary caster. You can’t replace a secondary caster who is the target of the spell (as in the atone ritual)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c44d9368-25b0-4d18-aded-eb2f425a3d1e"), Feats.Instances.RitualistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8dad2f2-6382-4e18-98b3-e956d7b9f2b8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
