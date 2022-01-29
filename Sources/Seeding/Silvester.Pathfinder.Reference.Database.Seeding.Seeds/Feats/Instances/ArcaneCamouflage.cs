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
    public class ArcaneCamouflage : Template
    {
        public static readonly Guid ID = Guid.Parse("deedd534-81a1-4c4f-a9b5-9422eab429fc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Camouflage",
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
            yield return new TextBlock { Id = Guid.Parse("5c505a60-81a5-4e6a-bf58-9027a7d9e7b3"), Type = TextBlockType.Text, Text = $"You have developed magical techniques to aid you with stalking your prey. You can cast {ToMarkdownLink<Models.Entities.Spell>("blur", Spells.Instances.Blur.ID)} and {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)} each once per day as 2nd-level arcane innate spells." };
            yield return new TextBlock { Id = Guid.Parse("9bfbdfaf-2331-4d7d-bf68-a94a29596fb0"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("7b880aee-f059-423a-b7ec-132bc32785d9"), Type = TextBlockType.Text, Text = $"~ Enhancement: Your camouflage is more potent. Your {ToMarkdownLink<Models.Entities.Spell>("blur", Spells.Instances.Blur.ID)} spell now lasts 10 minutes and when you cast {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)}, you can choose to gain the effects of the 4th-level version of the spell. In addition, you can now cast {ToMarkdownLink<Models.Entities.Spell>("blur", Spells.Instances.Blur.ID)} and {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)} each twice per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("fa44ba9d-cee4-4ca5-82b4-70986bd83f7a"), Heritages.Instances.HunterAutomaton.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf611f71-0b98-4d61-9c4e-76d58b3dc334"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
