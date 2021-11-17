using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class RiteOfLight : Template
    {
        public static readonly Guid ID = Guid.Parse("56d5e74a-f6f6-4a12-bce7-1d2e696ecc49");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Rite of Light"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("86733d5e-a73a-4c3c-aeed-9516ed4f2da0"), Type = TextBlockType.Text, Text = "Your exoskeleton bears small shoots that can share life. When using your Sunlight Healing, you can restore the Hit Points of an adjacent ally instead of yourself. That ally becomes temporarily immune to all uses of Sunlight Healing for 1 day." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("1463863e-796f-4663-bf1c-0f8a3ea75806"), "When using your Sunlight Healing, you can restore the Hit Points of an adjacent ally instead of yourself. That ally becomes temporarily immune to all uses of Sunlight Healing for 1 day.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21f13f21-d7b3-49b9-ad31-558372a4d5d2"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 107
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Conrasu.ID;
        }
    }
}
