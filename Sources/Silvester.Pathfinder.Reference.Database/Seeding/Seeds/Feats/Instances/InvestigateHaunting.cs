using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvestigateHaunting : Template
    {
        public static readonly Guid ID = Guid.Parse("be02f548-37d9-4c85-a065-bad464c53ad0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Investigate Haunting",
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
            yield return new TextBlock { Id = Guid.Parse("3a3a29b4-11d6-4ef0-b62f-9d6da38e5a3a"), Type = TextBlockType.Text, Text = "You are skilled at noticing the telltale signs of ghosts and hauntings. Even when you aren&#39;t (action: Investigating | Investigate) in exploration mode, you get a check to (action: Recall Knowledge) about incorporeal undead and haunts active in the area. You also gain a +2 circumstance bonus to skill checks to disable haunts." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1e74abd0-788d-4072-abf9-861acc7002b9"), Feats.Instances.GhostHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e070097f-e3fa-4d1d-81f4-83959af1a94c"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
