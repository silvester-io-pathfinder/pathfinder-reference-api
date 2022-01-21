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
    public class SewerRat : Template
    {
        public static readonly Guid ID = Guid.Parse("514d58c0-5237-4225-bf33-cad6020b7ed1");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Sewer Rat"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6470bc96-ca1c-417d-8718-732ad3d9fd59"), Type = TextBlockType.Text, Text = "You come from a long line of ysoki from a community based in the sewers beneath a large settlement. You are immune to the disease filth fever. Each of your successful saving throws against a disease or poison reduces its stage by 2, or by 1 for a virulent disease or poison. Each critical success against an ongoing disease or poison reduces its stage by 3, or by 2 for a virulent disease or poison." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("770c78ca-090b-40e2-8b25-1ce85748a8bd"), "You are immune to the disease filth fever.");
            builder.Manual(Guid.Parse("a104048a-8122-40f6-afea-726e15ae77dd"), "Each of your successful saving throws against a disease or poison reduces its stage by 2, or by 1 for a virulent disease or poison. Each critical success against an ongoing disease or poison reduces its stage by 3, or by 2 for a virulent disease or poison.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea9e84bd-d67a-42b3-a8db-e0ae80b46088"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 22
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Ratfolk.ID;
        }
    }
}
