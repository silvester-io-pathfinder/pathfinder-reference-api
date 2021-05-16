using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PrismaticSpray : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Prismatic Spray",
                Level = 7,
                Area = "30-foot cone.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A spray of rainbow light beams cascades from your open hand. Each creature in the area must roll 1d8 on the table below to see which beam affects it, then attempt a saving throw of the indicated type. The table notes any additional traits that apply to each type of ray. If a creature is struck by multiple beams, it uses the same d20 result for all its saving throws. For all rays, a successful saving throw negates the effect for that creature." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "1 - Red - Reflex Save" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "50 fire damage (fire)" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "2 - Orange - Reflex Save" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "60 acid damage (acid)" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "3 - Yellow - Reflex Save" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "70 electricity damage (electricity)" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "4 - Green - Fortitude Save" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "30 poison damage and enfeebled 1 for 1 minute (poison)" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "5 - Blue - Fortitude Save" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Affected as if by flesh to stone" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "6 - Indigo - Will Save" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Confused, as the warp mind spell(mental)" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "7 - Violet - Will Save" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Slowed 1 for 1 minute; if a critical failure, sent to another plane, as plane shift (teleportation)" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "8 - Potent Beam" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Affected by two beams—roll beam twice, rerolling any duplicates or results of 8" };
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Light.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 360
            };
        }
    }
}
