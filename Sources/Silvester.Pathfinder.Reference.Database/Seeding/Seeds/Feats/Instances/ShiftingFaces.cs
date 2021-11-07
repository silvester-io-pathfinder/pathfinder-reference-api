using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShiftingFaces : Template
    {
        public static readonly Guid ID = Guid.Parse("725e3868-97c1-4b89-83ce-00d0c256e55f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shifting Faces",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("27d2d6bd-62bf-47e2-8856-3da7dee6ac91"), Type = TextBlockType.Text, Text = "You wear many faces, even those that don’t belong to you. When you (action: Change Shape | Change Shape - Kitsune) into your tailless form, you gain the effects of 3rd-level (spell: illusory disguise) for 1 hour or until you shift back, except it’s a (trait: transmutation) effect rather than an (trait: illusion)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("2846efed-b1d8-4f8a-a898-6b5d75dba07b"), "Tailless alternate form.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5a2e6c7-5840-463c-bc8b-046da1b007f0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
