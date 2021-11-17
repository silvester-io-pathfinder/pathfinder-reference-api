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
    public class Construct : Template
    {
        public static readonly Guid ID = Guid.Parse("99eba98b-a3c3-4a18-a1d9-a1add24b6772");

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
            yield return new TextBlock { Id = Guid.Parse("ec328e3c-033d-4da3-b646-8d62978cc43c"), Type = TextBlockType.Text, Text = "Your innovation is a mechanical creature, such as a clockwork construct made of cogs and gears. It's a prototype construct companion, and you can adjust most of its base statistics by taking feats at higher levels, such as Advanced Companion. If you use the Overdrive action, your construct gains the same Overdrive benefits you do, and it also takes the same amount of fire damage on a critical failure." };
            yield return new TextBlock { Id = Guid.Parse("71e0a182-9123-4ce7-8e62-8b447abd52a7"), Type = TextBlockType.Text, Text = "You know how to spend additional time directing, controlling, or programming your construct innovation for a more complex plan of action. You can spend 2 actions to Command instead of 1 when commanding your construct companion; your construct companion can then use an additional action (normally 3 actions, rather than 2)." };
            yield return new TextBlock { Id = Guid.Parse("56792a66-e0ba-4f1d-aa26-fc58d765c817"), Type = TextBlockType.Text, Text = "Choose one initial construct modification to apply to your innovation, either from the following or from other initial construct modifications to which you have access. These modifications alter the construct's abilities or form." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyPrototypeConstructCompanion(Guid.Parse("362e24ca-cb78-45e2-86fe-354edbcd769b"));
            builder.GainAnyInnovationModification(Guid.Parse("dc731eb7-4c99-4cc8-8049-9db61b43171b"), InnovationModificationTypes.Instances.Initial.ID);
            //TODO: Add enhanced Command feat effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bc7c163-5151-4cfa-b712-dcdabedf76d0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 17
            };
        }
    }
}
