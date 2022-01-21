using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaskOfPain : Template
    {
        public static readonly Guid ID = Guid.Parse("e8c961cd-4b5c-48e2-9a31-05488cd2973e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mask of Pain",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You succeed at a Demoralize check.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5916e8b8-37a8-433e-8ad8-1bef54582dff"), Type = TextBlockType.Text, Text = "Your mask has grown into a manifestation of your pain, which you can release. The creature you successfully (action: Demoralized | Demoralize) takes 2d6 mental damage, or 4d6 mental damage if you're legendary in Intimidation. The target is then temporarily immune to additional damage from Mask of Pain for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9e74f02e-f5ae-43af-86f2-6fb5cb814aaf"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
            builder.HaveSpecificFeat(Guid.Parse("48659221-def0-4a81-b573-ab4c80c6c1c6"), Feats.Instances.OrcWarmask.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61c950a3-1d26-4278-94e1-b6ff793e2102"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
