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
    public class DistractingSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("0df4b8d5-c482-4478-a4e3-080b9dc5c2d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distracting Spellstrike",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f4c1d2f3-104a-4aa6-9a97-46e49763ac26"), Type = TextBlockType.Text, Text = $"You weave distracting magic with one hand to enhance your {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)}. Make a {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} and {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)} against the target of your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. Do this immediately before making the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, but after choosing your target. The {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)} gains the {ToMarkdownLink<Models.Entities.Trait>("arcane", Traits.Instances.Arcane.ID)}, {ToMarkdownLink<Models.Entities.Trait>("illusion", Traits.Instances.Illusion.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} traits, and it always has the basic effects of a {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)}, rather than applying any adjustments or alternate effects from other feats or abilities." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHybridStudy(Guid.Parse("2bf061f3-2ff4-4a99-aa6c-6c2ce0697481"), HybridStudies.Instances.LaughingShadow.ID);
            builder.HaveSpecificFeat(Guid.Parse("45c2d908-bb58-4a91-94e0-ac4a59c2c450"), Feats.Instances.Spellstrike.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90ae0674-e273-4551-86c0-64b7a55328bf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
