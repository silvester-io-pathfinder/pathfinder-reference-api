using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class Stubborn : Template
    {
        public static readonly Guid ID = Guid.Parse("8d5e9651-5cf4-4d31-a4d8-0031355a8772");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Stubborn", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a97cbf2d-d978-4e70-a1d5-4b36fa97d079"), Type = TextBlockType.Text, Text = "You don't like being told what to do, and you don't give up. Your proficiency rank for Will saves increases to expert. When you fail, but don't critically fail, a Will save against an effect that would give you the controlled condition, you can attempt a second save against the effect at the start of your next turn. On a successful second save, the controlled condition ends, though any other effects remain. As normal, failing this second save doesn't allow you to attempt a third save on the subsequent turn." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("d0a8f4d9-30bf-4dca-a899-0820a52892ae"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);
            //TODO: Add the second try effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b451603a-527e-411a-946a-16aad90a82f6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
