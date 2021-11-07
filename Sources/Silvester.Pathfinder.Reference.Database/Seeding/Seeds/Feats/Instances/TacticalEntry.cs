using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TacticalEntry : Template
    {
        public static readonly Guid ID = Guid.Parse("f8e6f0c0-f628-4548-a309-5ea438e1c8e4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tactical Entry",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("455b033c-f114-438e-a683-b5d4761ee1e3"), Type = TextBlockType.Text, Text = "You (action: Stride). This movement doesn’t trigger any reactions." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3370d2d3-2af6-4d41-9461-0023a8719e79"), Proficiencies.Instances.Master.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a1533e2-04d3-46e0-aa7c-54f14c5114c0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
