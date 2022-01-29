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
    public class MeteoricSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("b8786c20-2aae-4ced-82d3-6c2ee50c5f42");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Meteoric Spellstrike",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7455e776-2051-4ac4-b2f0-860ed1f47170"), Type = TextBlockType.Text, Text = $"A trail of energy flows from your target back to you. Make a {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} with a ranged weapon or ranged unarmed attack against a target within the ranged weapon or unarmed attack's first range increment. The spell you cast for the {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)} can't be a cantrip or focus spell. Each creature in a line between you and the target, excluding you and the targer, takes damage equal to double the spell's level. Determine the damage type as described in {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f424e860-6adb-4ffa-a236-d77e0d7d2cdb"), Feats.Instances.Spellstrike.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("ae83a9fd-b5bf-4b24-b92f-1033cc9ba90a"), HybridStudies.Instances.StarlitSpan.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb5e9524-d146-4ddf-a773-2241522ef326"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
