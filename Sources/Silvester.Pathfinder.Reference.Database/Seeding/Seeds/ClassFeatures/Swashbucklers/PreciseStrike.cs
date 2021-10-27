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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You strike with flair. When you have panache and you Strike with an agile or finesse melee weapon or agile or finesse unarmed attack, you deal 2 additional precision damage. If the strike is part of a finisher, the additional damage is 2d6 precision damage instead." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As your swashbuckler level increases, so does your additional damage for precise strike. Increase the amount of additional damage on a Strike and the number of additional dice on a finisher by one at 5th, 9th, 13th, and 17th levels." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 85
            };
        }
    }
}
