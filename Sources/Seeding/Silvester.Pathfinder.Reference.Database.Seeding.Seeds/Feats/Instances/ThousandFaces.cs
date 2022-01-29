using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThousandFaces : Template
    {
        public static readonly Guid ID = Guid.Parse("e02726e6-2859-4f5e-bbdc-3232836fe859");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thousand Faces",
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
            yield return new TextBlock { Id = Guid.Parse("ea22531b-6b9f-4778-a410-ed9cf7d420f0"), Type = TextBlockType.Text, Text = $"Your form is as mutable as the weather, changing to meet your whim. You add the forms listed in {ToMarkdownLink<Models.Entities.Spell>("humanoid form", Spells.Instances.HumanoidForm.ID)} to your wild shape list." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d64961bd-93df-43f2-8e45-4a0237437d1c"), Feats.Instances.WildShape.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Druid.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e2e8d1d-eea2-4488-a19f-e942a858345f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
