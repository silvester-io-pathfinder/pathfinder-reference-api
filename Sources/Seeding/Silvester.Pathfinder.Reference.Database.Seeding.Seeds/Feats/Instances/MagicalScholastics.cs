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
    public class MagicalScholastics : Template
    {
        public static readonly Guid ID = Guid.Parse("3c632523-17bb-46b2-babf-12770a120403");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Scholastics",
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
            yield return new TextBlock { Id = Guid.Parse("f6d730eb-5ed0-4670-8540-25195c1ca188"), Type = TextBlockType.Text, Text = $"While study is key to your success, a bit of magic is a helpful tool in discovering the secrets of the past. You gain {ToMarkdownLink<Models.Entities.Spell>("detect magic", Spells.Instances.DetectMagic.ID)}, {ToMarkdownLink<Models.Entities.Spell>("guidance", Spells.Instances.Guidance.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("read aura", Spells.Instances.ReadAura.ID)} as occult innate cantrips." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6b351ac6-3038-404d-865a-1575b6f8e9fa"), Feats.Instances.ArchaeologistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0b13148-5ae0-4a6e-8dfe-d849cd873834"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
