using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WeaponOfJudgement : Template
    {
        public static readonly Guid ID = Guid.Parse("44587a27-1340-41c9-971f-60fa21be2cc2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Weapon of Judgement",
                Level = 9,
                Range = "100 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                Requirements = "You have a deity.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82ea5417-c9a8-459b-97c0-967f1daaa2e3"), Type = TextBlockType.Text, Text = "An immense weapon of force appears, hovering in the air above the target. The weapon has the ghostly visual appearance of your deity’s favored weapon. Name war or peace when you cast this spell." };
            yield return new TextBlock { Id = Guid.Parse("116c71dd-0041-47b2-996a-04d6ca06d64f"), Type = TextBlockType.Text, Text = "If you name “war,” mentally choose one creature. This must be a creature both you and the target can see. The target instinctively knows which creature this is. At the end of each of the target’s turns, if the target did not use a hostile action against the creature you chose during that turn, the weapon Strikes the target." };
            yield return new TextBlock { Id = Guid.Parse("b2f5f94a-f030-409d-bf5e-ada21e118fcd"), Type = TextBlockType.Text, Text = "If you name “peace,” mentally choose up to five allies. The target instinctively knows who those allies are. The weapon Strikes the target each time the target uses a hostile action against you or one of your allies. The weapon Strikes only once per action, even if the action targets multiple allies (such as for a fireball or a Whirlwind Strike)." };
            yield return new TextBlock { Id = Guid.Parse("d0b8b581-3361-46d3-a191-307cd4dc1b96"), Type = TextBlockType.Text, Text = "Strikes with the weapon are melee weapon attacks, but they use your spell attack modifier. Regardless of its appearance, the weapon deals force damage equal to 3d10 plus your spellcasting ability modifier. The weapon takes a multiple attack penalty, which increases throughout the target’s turn, but its penalty is separate from yours." };
            yield return new TextBlock { Id = Guid.Parse("d314cc21-ae49-44f7-8ca7-f9f43a896c46"), Type = TextBlockType.Text, Text = "When the weapon Strikes, you can deal damage of the normal damage type of the weapon instead of force damage (or any of the available damage types, for a versatile weapon). No other statistics or attributes of the weapon apply, and even a ranged weapon attacks adjacent creatures only. A weapon of judgment is a weapon for the purposes of triggers, resistances, and so forth." };
            yield return new TextBlock { Id = Guid.Parse("9ee7d4f2-71cf-44e4-b6ae-4a41df71b5bf"), Type = TextBlockType.Text, Text = "The weapon doesn’t take up space, grant flanking, or have any other attributes a creature would. The weapon can’t make any attack other than its Strike, and feats or spells that affect weapons do not apply to this weapon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d3a61078-5da9-47ea-9939-869bda5001a7"), 
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("91465c05-35f4-4633-b491-d884759d2d6b"), Type = TextBlockType.Text, Text = "The force damage increases by 1d10." }
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
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Force.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd97fbb2-6dc6-4158-a4e4-c5fee3468c79"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 384
            };
        }
    }
}
