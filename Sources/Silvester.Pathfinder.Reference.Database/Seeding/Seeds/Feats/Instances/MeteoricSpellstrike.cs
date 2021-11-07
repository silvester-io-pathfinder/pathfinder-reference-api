using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MeteoricSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("50e9b647-b8e2-4e51-a8eb-6038da582aa5");

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
            yield return new TextBlock { Id = Guid.Parse("362ecd52-00ae-4a01-8e08-b927fc021471"), Type = TextBlockType.Text, Text = "A trail of energy flows from your target back to you. Make a (feat: Spellstrike) with a ranged weapon or ranged unarmed attack against a target within the ranged weapon or unarmed attack’s first range increment. The spell you cast for the (feat: Spellstrike) can’t be a cantrip or focus spell. Each creature in a line between you and the target, excluding you and the targer, takes damage equal to double the spell&#39;s level. Determine the damage type as described in (feat: Arcane Cascade)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f63dac53-155b-462a-b4e4-b8be101ac33c"), Feats.Instances.Spellstrike.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("fc6a50df-1e04-4a02-9649-c64b6f54f93c"), HybridStudies.Instances.StarlitSpan.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f17dd8bf-5ddb-49b4-8a35-20b13f9abf6d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
