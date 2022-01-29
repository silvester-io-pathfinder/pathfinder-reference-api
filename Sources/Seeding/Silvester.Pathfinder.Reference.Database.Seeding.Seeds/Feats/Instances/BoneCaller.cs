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
    public class BoneCaller : Template
    {
        public static readonly Guid ID = Guid.Parse("3b6aca62-aadc-485e-8272-19c48e7bc5bb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bone Caller",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("24703a6e-a1c9-4106-9b19-ef8624fb154f"), Type = TextBlockType.Text, Text = $"Using a mixture of dinosaur bones and the bones of your ancestors to focus your magic, you animate lizards and dinosaurs to carry messages or serve as mounts. You can cast {ToMarkdownLink<Models.Entities.Spell>("animal messenger", Spells.Instances.AnimalMessenger.ID)} and {ToMarkdownLink<Models.Entities.Spell>("phantom steed", Spells.Instances.PhantomSteed.ID)} as primal innate spells once per day each. The animal messenger is always a Tiny dinosaur or lizard, and your innate spell transforms it from bones to flesh, even if there are no dinosaurs or lizards nearby. The phantom steed looks like a dinosaur rather than a horse but functions identically." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Lizardfolk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0697187-f8e5-41f2-ba29-4b735896bfad"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
