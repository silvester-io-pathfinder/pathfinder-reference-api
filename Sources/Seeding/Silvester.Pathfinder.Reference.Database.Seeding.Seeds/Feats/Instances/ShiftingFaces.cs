using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShiftingFaces : Template
    {
        public static readonly Guid ID = Guid.Parse("b23adc12-6451-48d8-8db6-995bc6dd0d28");

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
            yield return new TextBlock { Id = Guid.Parse("4bba5c1d-5094-45df-8335-1b07ca78cbfd"), Type = TextBlockType.Text, Text = $"You wear many faces, even those that don't belong to you. When you {ToMarkdownLink<Models.Entities.Feat>("Change Shape", Feats.Instances.ChangeShapeKitsune.ID)} into your tailless form, you gain the effects of 3rd-level {ToMarkdownLink<Models.Entities.Spell>("illusory disguise", Spells.Instances.IllusoryDisguise.ID)} for 1 hour or until you shift back, except it's a {ToMarkdownLink<Models.Entities.Trait>("transmutation", Traits.Instances.Transmutation.ID)} effect rather than an {ToMarkdownLink<Models.Entities.Trait>("illusion", Traits.Instances.Illusion.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("ed7b8dc9-5c94-4e41-930f-887edb2db24f"), "Tailless alternate form.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6859331f-8054-4d30-bb35-cf69f07cdb0f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
