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
    public class WildbornAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("c6473526-5766-4383-b660-717a9f680d3c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wildborn Adept",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5d8e879-6b7f-47dd-aeef-a384d172cb8a"), Type = TextBlockType.Text, Text = $"The whispers of the jungle grant you more diverse access to simple primal magic. You can cast {ToMarkdownLink<Models.Entities.Spell>("dancing lights", Spells.Instances.DancingLights.ID)}, {ToMarkdownLink<Models.Entities.Spell>("disrupt undead", Spells.Instances.DisruptUndead.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("tanglefoot", Spells.Instances.Tanglefoot.ID)} as innate primal spells at will. If you chose one of those spells with {ToMarkdownLink<Models.Entities.Feat>("Wildborn Magic", Feats.Instances.WildbornMagic.ID)}, you can select a new spell for {ToMarkdownLink<Models.Entities.Feat>("Wildborn Magic", Feats.Instances.WildbornMagic.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a7c976b4-e677-41d6-8624-e93a3d64849a"), Feats.Instances.WildbornMagic.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Elf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0de65ca0-82f2-46ca-8660-41c80c57a79c"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
