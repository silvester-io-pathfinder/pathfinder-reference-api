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
    public class AeonResonance : Template
    {
        public static readonly Guid ID = Guid.Parse("be314f22-0690-40d4-a85d-5c6b099ec8ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aeon Resonance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "At 8th level, you can take this feat again. If you do, you gain the resonance powers of up to four invested aeon stones instead of only one.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8040de2f-21f9-407e-a074-26f596edebd0"), Type = TextBlockType.Text, Text = $"You gain the resonant power of one embedded aeon stone as if it were placed in a wayfinder. While you can embed multiple aeon stones in your flesh, you can gain the resonance power from only one embedded stone at a time, selected each day when you make your daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c1ba3882-f2ca-4c4f-9fdc-00f5a5e2f25f"), Feats.Instances.EmbedAeonStone.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("585ec100-27ee-4043-80e1-a0a1cac7b9dc"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a66412de-038b-4e86-aef2-60d719d4f75d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
