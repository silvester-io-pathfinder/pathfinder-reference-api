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
    public class Miresoul : Template
    {
        public static readonly Guid ID = Guid.Parse("5a7794a5-3e38-4e8f-accf-96bc10f759a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Miresoul",
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
            yield return new TextBlock { Id = Guid.Parse("c3cbdce0-e298-45bf-8422-f2b8bccbce73"), Type = TextBlockType.Text, Text = $"You have a connection to the muddier denizens of the Plane of Earth from its border with the Plane of Water, and your elemental lineage manifests as clay or mud, reflecting that bond. Your body's mudlike quality makes it easy for you to compress and squeeze yourself through smaller areas. You gain the trained proficiency rank in Acrobatics. If you would automatically become trained in Acrobatics (from your background or class, for example), you instead become trained in a skill of your choice. You gain the {ToMarkdownLink<Models.Entities.Feat>("Quick Squeeze", Feats.Instances.QuickSqueeze.ID)} skill feat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Lineage.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Oread.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9745627d-f943-47f9-8624-e44e27443287"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
