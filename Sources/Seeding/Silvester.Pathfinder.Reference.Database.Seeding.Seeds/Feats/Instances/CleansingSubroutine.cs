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
    public class CleansingSubroutine : Template
    {
        public static readonly Guid ID = Guid.Parse("8769b0e4-8da5-4e37-889d-44e73f74ca44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cleansing Subroutine",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("770b69d5-3b2d-491b-8e2f-5eb5bd565056"), Type = TextBlockType.Text, Text = $"Your nanites help purge your body of harmful chemicals and toxins. Each time you succeed at a Fortitude save against an ongoing poison, you reduce its stage by 2, or by 1 against a {ToMarkdownLink<Models.Entities.Trait>("virulent", Traits.Instances.Virulent.ID)} poison. Each critical success you achieve against an ongoing poison reduces its stage by 3, or by 2 against a {ToMarkdownLink<Models.Entities.Trait>("virulent", Traits.Instances.Virulent.ID)} poison." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("db9a5eb9-5bdf-452a-8a8b-870a22f1b684"), Traits.Instances.Android.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("640ec4fb-3c71-4b3d-98ae-d8476e3458ef"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
