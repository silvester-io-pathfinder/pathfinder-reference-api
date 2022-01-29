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
    public class DenyTheSongsOfWar : Template
    {
        public static readonly Guid ID = Guid.Parse("847ac2e0-dd23-4d62-b48c-9e006a095633");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deny the Songs of War",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("930890de-5008-495b-8873-328a656f6fb5"), Type = TextBlockType.Text, Text = $"To keep the peace, you disrupt those who seek to break it. You can cast {ToMarkdownLink<Models.Entities.Spell>("deafness", Spells.Instances.Deafness.ID)} and 4th-level {ToMarkdownLink<Models.Entities.Spell>("silence", Spells.Instances.Silence.ID)} once per day each as innate spells. The tradition of these spells is the one you chose for the Nantambu Chime-Ringer Dedication feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1a9b2a20-db0e-4f6a-8f4b-d9ff0dde29bc"), Feats.Instances.NantambuChimeRingerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9151db32-5eba-4db8-a3e3-eea8d0dc086f"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
