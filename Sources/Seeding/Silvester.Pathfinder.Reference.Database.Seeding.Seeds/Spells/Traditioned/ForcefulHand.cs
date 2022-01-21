using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ForcefulHand : Template
    {
        public static readonly Guid ID = Guid.Parse("5edb11c0-c042-4a80-86a0-c5a21cf03291");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Forceful Hand",
                Level = 5,
                Range = "60 feet.",
                Duration = "Sustained up to 1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee984251-a41c-4ce1-abbb-e7e77350dbed"), Type = TextBlockType.Text, Text = "A Medium floating, disembodied hand made of magical force appears in an unoccupied space adjacent to you, following you across the battlefield to shield you against your foes� attacks. Each time you Sustain the Spell, the hand moves to an unoccupied space of your choice adjacent to you. When you Sustain the Spell, you can have the hand Fly to an unoccupied space of your choice adjacent to an ally to protect that ally instead. The hand�s movement does not trigger reactions based on creature movement." };
            yield return new TextBlock { Id = Guid.Parse("9392c677-6e37-41af-a05b-b1d5a1711982"), Type = TextBlockType.Text, Text = "Successful attacks against the hand damage it, and damaging effects that can target a creature can target the hand. The hand has an AC of 25, 50 Hit Points, and can�t recover HP by any means. A hit by a disintegrate spell or similar effect destroys the hand." };
            yield return new TextBlock { Id = Guid.Parse("a5403588-9c74-4839-8086-5b2732f4c1cb"), Type = TextBlockType.Text, Text = "The hand�s actions and the cover it provides depend on what actions you take during your turn. At the end of your turn, what the hand does is determined by the first entry on this list that matches a trait from any of the actions you used on your turn. For instance, if you Step, Stride, and Sustain the Spell, you use the entry for move actions, so the hand provides standard cover." };
            yield return new TextBlock { Id = Guid.Parse("91e8437b-05d5-42b4-91cc-3d80c2053dc4"), Type = TextBlockType.Enumeration, Text = "Manipulate or Attack The hand interposes between you and your foes. It provides lesser cover (+1 circumstance bonus to AC) against all attacks that pass through the hand�s square." };
            yield return new TextBlock { Id = Guid.Parse("69c25f6a-4acf-430a-9ef3-1409e222b67e"), Type = TextBlockType.Enumeration, Text = "Move The hand provides standard cover (+2 circumstance bonus to AC, Reflex, and Stealth checks) against all attacks that pass through the hand�s square." };
            yield return new TextBlock { Id = Guid.Parse("7a1b9601-806c-4cdd-a875-0671652f53cc"), Type = TextBlockType.Enumeration, Text = "Concentrate The hand provides greater cover (+4 circumstance bonus to AC, Reflex, and Stealth checks) against all attacks that pass through the hand�s square." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("29f80511-a255-4ff8-86b3-64860d35b865"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("8552a009-c4a6-42bd-8113-a066a34171a8"), Type = TextBlockType.Text, Text = "The hand has AC 27 and 60 Hit Points. When you Cast this Spell, you can choose to replace the hand�s Manipulate or Attack option with Swat." },
                    new TextBlock {Id = Guid.Parse("f7793824-02b4-433f-83b8-fe1acec4a611"), Type = TextBlockType.Enumeration, Text = "Swat The hand Flies to an enemy of your choice within range and attempts to Push that enemy, using your spell attack roll instead of an Athletics check to determine the results of the Push." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("68fe9eda-07ff-488b-9f8c-25dc720af82b"),
                Level = "7th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("0da483c6-f362-420d-80ff-13dc303b1cb7"), Type = TextBlockType.Text, Text = "The hand has AC 30 and 70 Hit Points, and it is Large. When you Cast this Spell, you can choose to replace the hand�s Manipulate or Attack option with Grasp or Swat." },
                    new TextBlock {Id = Guid.Parse("adbe2d67-faaf-4983-b884-40d05fa60ea6"), Type = TextBlockType.Enumeration, Text = "The hand Flies to an enemy of your choice within range and attempts to Grapple that enemy, using your spell attack roll instead of an Athletics check to determine the results of the Grapple." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("7b44cfb6-1e76-4426-ba29-1305759d6160"),
                Level = "8th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("6c627dd8-7a08-4e1e-9c6a-e43fc108e74b"), Type = TextBlockType.Text, Text = "The hand has AC 32 and 80 Hit Points, and it is Large. When you Cast this Spell, you can choose to replace the hand�s Manipulate or Attack option with Grasp, Punch, or Swat." },
                    new TextBlock {Id = Guid.Parse("6c36f7e0-23e3-4dff-81cf-005c70d640cb"), Type = TextBlockType.Enumeration, Text = "Punch The hand Flies to an enemy of your choice within range and attempts to Strike that enemy with crushing force. The hand�s Strikes use your melee spell attack modifiers and deal 7d8 force damage. The hand�s Strikes don�t use or contribute to your multiple attack penalty." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("e0a764f1-cdff-45b2-9eec-617d84b8067c"),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("157fc8c1-75f9-4df0-938c-0f709edca0b9"), Type = TextBlockType.Text, Text = "The hand has AC 35 and 90 Hit Points, and it is Large. When you Cast this Spell, you can choose to replace the hand�s Manipulate or Attack option with Crush, Grasp, Punch, or Swat." },
                    new TextBlock {Id = Guid.Parse("6e8666be-ab83-4ab7-9d03-37c434b057b9"), Type = TextBlockType.Enumeration, Text = "Crush If the hand doesn�t have a target grabbed, it Flies to an enemy of your choice within range and attempts to Strike that enemy with deadly crushing force. The hand�s Strikes are melee spell attacks that deal 6d8 force damage. The hand�s Strikes don�t take or contribute to your multiple attack penalty. On a successful Strike, the target is grabbed by the hand until the end of your next turn, unless the hand moves or the target successfully Escapes against your spell DC. However, if the hand has a target grabbed when it uses Crush, it instead Constricts the target, dealing 6d8 force damage with a basic Fortitude save." }
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("584a16f3-db79-4014-b3e9-923880881526"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("e6185317-4d13-4be2-935b-722a5cf132d2"), Traits.Instances.Force.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d5fa98c-4ac3-43f6-94c3-b1c9632039ed"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 106
            };
        }
    }
}
