using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Innovations.Instances
{
    public class ConstructInnovation : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Innovation GetInnovation()
        {
            return new Innovation
            {
                Id = ID,
                Name = "Construct Innovation",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your innovation is a mechanical creature, such as a clockwork construct made of cogs and gears. It's a prototype construct companion, and you can adjust most of its base statistics by taking feats at higher levels, such as Advanced Companion. If you use the Overdrive action, your construct gains the same Overdrive benefits you do, and it also takes the same amount of fire damage on a critical failure." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You know how to spend additional time directing, controlling, or programming your construct innovation for a more complex plan of action. You can spend 2 actions to Command instead of 1 when commanding your construct companion; your construct companion can then use an additional action (normally 3 actions, rather than 2)." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Choose one initial construct modification to apply to your innovation, either from the following or from other initial construct modifications to which you have access. These modifications alter the construct's abilities or form." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyPrototypeConstructCompanion(Guid.Parse(""));
            builder.GainAnyInnovationModification(Guid.Parse(""), InnovationModificationTypes.Instances.Initial.ID);
            //TODO: Add enhanced Command feat effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 17
            };
        }
    }
}
