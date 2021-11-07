using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaskOfPain : Template
    {
        public static readonly Guid ID = Guid.Parse("869a86af-1af2-47ba-b903-098728920690");

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
            yield return new TextBlock { Id = Guid.Parse("70673a43-8b3e-47b0-bd75-e36942374af0"), Type = TextBlockType.Text, Text = "Your mask has grown into a manifestation of your pain, which you can release. The creature you successfully (action: Demoralized | Demoralize) takes 2d6 mental damage, or 4d6 mental damage if you’re legendary in Intimidation. The target is then temporarily immune to additional damage from Mask of Pain for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("da455c4c-3e16-485c-ba4d-960b596ba655"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
            builder.HaveSpecificFeat(Guid.Parse("65e3d95b-7e43-451f-9943-9f79783dc7e1"), Feats.Instances.OrcWarmask.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1add7ca1-9404-45b0-82c6-ca4382628ae1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
