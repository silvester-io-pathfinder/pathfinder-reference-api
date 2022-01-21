using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rules.Instances
{
    public class CastASpell : Template
    {
        public static readonly Guid ID = Guid.Parse("c4d04334-2f9b-4a29-b2cf-204c2d0e6495");
        
        protected override Rule GetRule()
        {
            return new Rule
            {
                Id = ID, 
                Name = "Cast a Spell",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("05c16a40-db9d-47b6-aad6-1f5bab27f7c1"), Type = TextBlockType.Text, Text = "You cast a spell you have prepared or in your repertoire. Casting a Spell is a special activity that takes a variable number of actions depending on the spell, as listed in each spell's stat block. As soon as the spellcasting actions are complete, the spell effect occurs." };
            yield return new TextBlock { Id = Guid.Parse("e21ef4e4-1373-4466-a6b7-3cd35720fc19"), Type = TextBlockType.Text, Text = "Some spells are cast as a reaction or free action. In those cases, you Cast the Spell as a reaction or free action (as appropriate) instead of as an activity." };
            yield return new TextBlock { Id = Guid.Parse("f06215dc-78c6-4d64-91c2-f3ef6f77ce00"), Type = TextBlockType.Heading, Text = "Long Casting Times" };
            yield return new TextBlock { Id = Guid.Parse("696fcd42-c77f-41e4-84f9-c48c1ca7f668"), Type = TextBlockType.Text, Text = "Some spells take minutes or hours to cast. The Cast a Spell activity for these spells includes a mix of the listed spell components, but it's not necessary to break down which one you're providing at a given time. You can't use other actions or reactions while casting such a spell, though at the GM's discretion, you might be able to speak a few sentences. As with other activities that take a long time, these spells have the exploration trait, and you can't cast them in an encounter. If combat breaks out while you're casting one, your spell is disrupted (see Disrupted and Lost Spells below)." };
            yield return new TextBlock { Id = Guid.Parse("418c3271-d398-4003-84b0-c5be500b3cca"), Type = TextBlockType.Heading, Text = "Spell Components" };
            yield return new TextBlock { Id = Guid.Parse("26d9aa38-d046-4efc-92de-2a02bfb78ebe"), Type = TextBlockType.Text, Text = " Each spell lists the spell components required to cast it after the action icons or text, such as 'Three Actions material, somatic, verbal.' The spell components, described in detail below, add traits and requirements to the Cast a Spell activity. If you can't provide the components, you fail to Cast the Spell." };
            yield return new TextBlock { Id = Guid.Parse("a2a622ed-49df-451c-bc3a-2d1e391e7c59"), Type = TextBlockType.Enumeration, Text = "- Material (manipulate)" };
            yield return new TextBlock { Id = Guid.Parse("543f7265-e7e6-4cf6-b6bf-3eb2273379fa"), Type = TextBlockType.Enumeration, Text = "- Somatic (manipulate)" };
            yield return new TextBlock { Id = Guid.Parse("a8af8bd3-f4b4-4848-91c5-dc4a2d3a0dce"), Type = TextBlockType.Enumeration, Text = "- Verbal (concentrate)" };
            yield return new TextBlock { Id = Guid.Parse("9220cf98-b23d-44aa-8707-9b87a07a6dc6"), Type = TextBlockType.Enumeration, Text = "- Focus (manipulate)" };
            yield return new TextBlock { Id = Guid.Parse("971984ca-a7c2-4d4a-9563-07c2d62b68b2"), Type = TextBlockType.Heading, Text = "Disrupted and Lost Spells" };
            yield return new TextBlock { Id = Guid.Parse("1e101053-7e5d-49fb-afd0-db0fc1586314"), Type = TextBlockType.Text, Text = "Some abilities and spells can disrupt a spell, causing it to have no effect and be lost. When you lose a spell, you've already expended the spell slot, spent the spell's costs and actions, and used the Cast a Spell activity. If a spell is disrupted during a Sustain a Spell action, the spell immediately ends." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ff701e0-2ad5-4769-9281-9b8ef862c85b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 301
            };
        }
    }
}
