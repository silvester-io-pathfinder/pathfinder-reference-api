using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class PreciseStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("ce32c37b-269f-401b-9378-2130aad69cf4");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Precise Strike", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("608fe887-31e1-43c8-ad6a-557a6f75773f"), Type = TextBlockType.Text, Text = "You strike with flair. When you have panache and you Strike with an agile or finesse melee weapon or agile or finesse unarmed attack, you deal 2 additional precision damage. If the strike is part of a finisher, the additional damage is 2d6 precision damage instead." };
            yield return new TextBlock { Id = Guid.Parse("6349fce5-c706-4e65-8517-029e7949b728"), Type = TextBlockType.Text, Text = "As your swashbuckler level increases, so does your additional damage for precise strike. Increase the amount of additional damage on a Strike and the number of additional dice on a finisher by one at 5th, 9th, 13th, and 17th levels." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45c72470-3e18-46b4-951a-5795a8ed6901"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 85
            };
        }
    }
}
