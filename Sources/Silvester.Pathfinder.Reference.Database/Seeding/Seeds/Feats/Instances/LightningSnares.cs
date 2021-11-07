using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LightningSnares : Template
    {
        public static readonly Guid ID = Guid.Parse("886516aa-8c3e-4f59-b537-607192d7f849");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lightning Snares",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e4005bc1-2e6b-409e-983a-af317edf073c"), Type = TextBlockType.Text, Text = "You can rig a trap with incredible speed. When you create a snare that normally takes 1 minute to (action: Craft), you can (action: Craft) it using a single (action: Interact) action instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3b551bec-89c7-41e5-b8ef-37e0c4243ddc"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("1073d082-06f9-4dd2-8d35-4bd1ef000947"), Feats.Instances.SnarecrafterDedictation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76383a0d-3e1b-44a4-8699-9dfacbb5e54d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
