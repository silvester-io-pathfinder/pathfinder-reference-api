using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Possession : Template
    {
        public static readonly Guid ID = Guid.Parse("0a35bb1b-49fa-4b19-b034-80a998f4b607");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Possession",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47b2776c-fad6-4670-bd39-f14cc6fa5e53"), Type = TextBlockType.Text, Text = "Effects with this trait allow a creature to project its mind and spirit into a target. A creature immune to mental effects can't use a possession effect. While possessing a target, a possessor's true body is unconscious (and can't wake up normally), unless the possession effect allows the creature to physically enter the target. Whenever the target takes damage, the possessor takes half that amount of damage as mental damage." };
            yield return new TextBlock { Id = Guid.Parse("9d4b09e3-fec1-4f59-8075-09bc854f5b67"), Type = TextBlockType.Text, Text = "A possessor loses the benefits of any of its active spells or abilities that affect its physical body, though it gains the benefits of the target's active spells and abilities that affect their body. A possessor can use any of the target's abilities that are purely physical, and it can't use any of its own abilities except spells and purely mental abilities. The GM decides whether an ability is purely physical or purely mental. A possessor uses the target's attack modifier, AC, Fortitude save, Reflex save, Perception, and physical skills, and its own Will save, mental skills, spell attack roll, and spell DC; benefits of invested items apply where relevant (the possessor's invested items apply when using its own values, and the target's invested items apply when using the target's values). A possessor gains no benefit from casting spells that normally affect only the caster, since it isn't in its own body." };
            yield return new TextBlock { Id = Guid.Parse("3132aa09-8544-4448-861d-8001b118bf44"), Type = TextBlockType.Text, Text = "The possessor must use its own actions to make the possessed creature act." };
            yield return new TextBlock { Id = Guid.Parse("702d0d7f-800d-401d-894a-3f6a58838d3f"), Type = TextBlockType.Text, Text = "If a possessor reaches 0 Hit Points through any combination of damage to its true body and mental damage from the possession, it is knocked out as normal and the possession immediately ends. If the target reaches 0 Hit Points first, the possessor can either fall unconscious with the body and continue the possession or end the effect as a free action and return to its body. If the target dies, the possession ends immediately and the possessor is stunned for 1 minute." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44c3f5e6-2948-44cf-9799-df2101fe974a"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
