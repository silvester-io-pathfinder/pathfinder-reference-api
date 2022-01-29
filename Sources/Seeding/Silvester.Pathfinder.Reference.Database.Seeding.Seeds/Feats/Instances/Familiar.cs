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
    public class Familiar : Template
    {
        public static readonly Guid ID = Guid.Parse("b3d7276a-b7df-4aa9-8cfa-d03c88590d23");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Familiar",
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
            yield return new TextBlock { Id = Guid.Parse("ab2be067-e382-4ba8-81fb-75c498d56468"), Type = TextBlockType.Text, Text = $"Whether by following occult rituals, piecing together scraps of arcane theory, or some other method, you've called forth a creature that now serves as your constant companion in your studies of the supernatural. You gain a familiar." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5c07c36c-3bce-4bdf-bc24-25b586398cf8"), Traits.Instances.Magus.ID);
            builder.Add(Guid.Parse("12112967-4c2c-438c-807d-3a2495561e50"), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse("a4082e30-ed01-4edd-be14-f0017c5a5c76"), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4d58538-0ddf-43a3-9653-0aea8790f610"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
