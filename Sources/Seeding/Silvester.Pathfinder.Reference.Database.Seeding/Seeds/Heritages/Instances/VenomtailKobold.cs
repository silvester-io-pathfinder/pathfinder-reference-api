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
    public class VenomtailKobold : Template
    {
        public static readonly Guid ID = Guid.Parse("bb53fcf4-24b8-443c-8914-5399d10a86e0");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Venomtail Kobold"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d64ce802-6531-449f-af27-8b858a4bb8b3"), Type = TextBlockType.Text, Text = "A vestigial spur in your tail secretes one dose of deadly venom each day. You gain the Tail Toxin action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("e0bd5084-2ce5-4ac0-b24e-52482cc791a1"), Feats.Instances.TailToxin.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf677c26-47ec-4cb9-beb4-6112df310ed1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 14
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kobold.ID;
        }
    }
}
