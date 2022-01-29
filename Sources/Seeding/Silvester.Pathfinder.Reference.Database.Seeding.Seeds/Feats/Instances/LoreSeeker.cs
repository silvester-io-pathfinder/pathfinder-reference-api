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
    public class LoreSeeker : Template
    {
        public static readonly Guid ID = Guid.Parse("c64c5b48-c8ff-4c67-ae47-8a00b3dd7169");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lore Seeker",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cdc3c656-0872-47a9-8b0b-4b0c5e58e658"), Type = TextBlockType.Text, Text = $"You see what others don't, and you've developed magical tricks to find hidden truth. You can cast {ToMarkdownLink<Models.Entities.Spell>("comprehend language", Spells.Instances.ComprehendLanguage.ID)}, {ToMarkdownLink<Models.Entities.Spell>("restore senses", Spells.Instances.RestoreSenses.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("see invisibility", Spells.Instances.SeeInvisibility.ID)} as innate spells, each once per day. If you could already cast spells, these spells are of the same tradition. Otherwise, they are arcane spells, you use Intelligence as your spellcasting ability, and you become trained in spell attack rolls and spell DCs for arcane spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1da69671-7ed4-43dc-9045-b0d4be7116eb"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("237106aa-59ce-45cd-840c-a631dd8df251"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a267292f-80b7-4464-9a29-51500d66c119"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
