using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Riptide : Template
    {
        public static readonly Guid ID = Guid.Parse("9e72d9b2-3ad7-4b2b-8eeb-7e4b4bfd75aa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Riptide",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You successfully Grapple a creature of the same size as you or smaller.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bf698d5b-75b3-4a79-abdd-14e0b530714f"), Type = TextBlockType.Text, Text = "You (action: Stride) up to 10 feet to enter the water, bringing the grabbed creature with you into the water." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cd51fed0-e495-4c76-ad1c-fa92f38f4e28"), Feats.Instances.DragDown.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("51ebb200-7508-4afc-98ae-28898101db95"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1355c045-1a11-484e-9d6a-122ec3ddba30"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
