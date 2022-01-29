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
    public class InstantBackup : Template
    {
        public static readonly Guid ID = Guid.Parse("00ed8f99-216c-43c2-8f8c-f9cdd99f323e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instant Backup",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your attack with a firearm misfires.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7e0a503c-2ec7-4a4c-9693-a334047e3c28"), Type = TextBlockType.Text, Text = $"Even as your firearm misfires, you quickly draw a backup weapon. {ToMarkdownLink<Models.Entities.Action>("Release", Actions.Instances.Release.ID)} the misfired weapon if you so choose, and {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw a one-handed weapon." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("970b28b0-891a-41e4-813e-db7fc2fde57f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
