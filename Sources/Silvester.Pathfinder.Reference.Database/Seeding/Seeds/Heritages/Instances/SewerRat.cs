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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You come from a long line of ysoki from a community based in the sewers beneath a large settlement. You are immune to the disease filth fever. Each of your successful saving throws against a disease or poison reduces its stage by 2, or by 1 for a virulent disease or poison. Each critical success against an ongoing disease or poison reduces its stage by 3, or by 2 for a virulent disease or poison." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "You are immune to the disease filth fever.");
            builder.Manual(Guid.Parse(""), "Each of your successful saving throws against a disease or poison reduces its stage by 2, or by 1 for a virulent disease or poison. Each critical success against an ongoing disease or poison reduces its stage by 3, or by 2 for a virulent disease or poison.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
