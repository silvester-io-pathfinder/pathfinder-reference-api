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
    public class VileDesecration : Template
    {
        public static readonly Guid ID = Guid.Parse("e50bb03d-25dd-45ee-857e-dcaec5e05f65");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vile Desecration",
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
            yield return new TextBlock { Id = Guid.Parse("eca35aff-94f8-452b-8231-5885734bc3bb"), Type = TextBlockType.Text, Text = $"You combine unholy might with negative energy to damage angels, archons, and other self-righteous denizens of the Outer Planes. When you cast a {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} spell, you can change the damage you deal to celestial creatures to evil damage instead of negative damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("e253dca1-e0e2-4e66-9937-2ae1b08b78eb"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("8ae8b930-5c26-4700-a7e7-2dcafe2305c1"), Alignments.Instances.LawfulEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("706d71df-b933-43fa-901a-c073b52249ab"), Alignments.Instances.NeutralEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("290fd1c6-f65a-4f78-a534-9a34b5b095c5"), Alignments.Instances.ChaoticEvil.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a677246-75cb-489e-8c52-d702cbde825d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
