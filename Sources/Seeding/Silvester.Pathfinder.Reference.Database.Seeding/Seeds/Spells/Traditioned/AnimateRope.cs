using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AnimateRope : Template
    {
        public static readonly Guid ID = Guid.Parse("759f85fa-7a3f-47da-a242-b699ee09c07b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Animate Rope",
                Level = 1,
                Range = "100 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                Targets = "Up to 50 feet of rope or a nonliving rope-like object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("afc0dee8-afa8-4305-ba16-16683aa509c7"), Type = TextBlockType.Text, Text = "You cause a length or section of rope or a rope-like object to animate and follow simple commands. You can give it two commands when you Cast the Spell, and one command each time you Sustain the Spell." };
            yield return new TextBlock { Id = Guid.Parse("cf5e76ef-7194-49da-a89d-bf8bac8e05dc"), Type = TextBlockType.Enumeration, Text = "Bind - (attack) The rope attempts to partially bind a creature. Attempt a spell attack roll against the target's Reflex DC. If you succeed, the target takes a –10-foot circumstance penalty to its Speed (–20-foot on a critical success). This ends if the target Escapes against your spell DC or breaks the rope. (A standard adventuring rope has Hardness 2, HP 8, and a Broken Threshold of 4.)" };
            yield return new TextBlock { Id = Guid.Parse("5a507497-a087-40c3-a857-248933c2d816"), Type = TextBlockType.Enumeration, Text = "Coil - The rope forms a tidy, coiled stack." };
            yield return new TextBlock { Id = Guid.Parse("8615309c-8bcc-4d24-976c-26157b6058f3"), Type = TextBlockType.Enumeration, Text = "Crawl - The rope inches along the ground like a snake, moving one of its ends 10 feet. The rope must move along a surface, but that surface doesn't need to be horizontal." };
            yield return new TextBlock { Id = Guid.Parse("6e544307-5cee-4b13-bbb2-5d874aedf86f"), Type = TextBlockType.Enumeration, Text = "Knot - The rope ties a sturdy knot in itself." };
            yield return new TextBlock { Id = Guid.Parse("36eebd9d-09df-4a2d-92b8-e26976330dd2"), Type = TextBlockType.Enumeration, Text = "Loop - The rope forms a simple loop at one or both ends, or straightens itself back out." };
            yield return new TextBlock { Id = Guid.Parse("b4494f03-6d3b-4d2f-8ed0-8c7a28c58a9a"), Type = TextBlockType.Enumeration, Text = "Tie - The rope ties itself around a willing creature or an object that's unattended or attended by a willing creature." };
            yield return new TextBlock { Id = Guid.Parse("9097a856-798e-40e5-a9e2-71c19dfd5a0c"), Type = TextBlockType.Enumeration, Text = "Undo - The rope undoes one of its knots, ties, or bindings." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cf5f9857-d16b-437d-a897-318b87924405"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5991ffc6-8b1a-4896-bc83-6b95b727d4df"), Type = TextBlockType.Text, Text = "The range increases by 50 feet, and you can animate 50 more feet of rope." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ffa10f2-fb8d-461f-b4ec-309d62238b3f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 214
            };
        }
    }
}
