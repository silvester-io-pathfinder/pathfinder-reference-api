using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Shield : Template
    {
        public static readonly Guid ID = Guid.Parse("5e0b7844-0a77-42f6-ab60-1d03d9f83310");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shield",
                Level = 1,
                Duration = "Until the start of your next turn.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7ae1970-d90f-40bc-b317-91cfa5a47d9b"), Type = TextBlockType.Text, Text = "You raise a magical shield of force. This counts as using the Raise a Shield action, giving you a +1 circumstance bonus to AC until the start of your next turn, but it doesn't require a hand to use." };
            yield return new TextBlock { Id = Guid.Parse("84e52283-6dd1-4f39-ac80-e164f482011c"), Type = TextBlockType.Text, Text = "While the spell is in effect, you can use the Shield Block reaction with your magic shield (see the sidebar). The shield has Hardness 5. After you use Shield Block, the spell ends and you can't cast it again for 10 minutes. Unlike a normal Shield Block, you can use the spell's reaction against the magic missile spell." };
            yield return new TextBlock { Id = Guid.Parse("73f02d3b-208c-4a58-857b-d6c2d7392a5a"), Type = TextBlockType.Text, Text = "Heightening the spell increases the shield's Hardness." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7ffed6b2-1012-451d-9ce3-0ea69346e7b4"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4d1083c6-59c3-4014-bce4-f0acd20fa53b"), Type = TextBlockType.Text, Text = "The shield has Hardness 10." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("c8b21ce8-5c1b-4484-aead-4582eafcda6d"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5f9092db-baa4-4b04-ade9-45175812ad72"), Type = TextBlockType.Text, Text = "The shield has Hardness 15." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("71a4cb4e-c8e8-40f4-9d1b-6a9f266ad451"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ab0629a1-beee-49a6-a99b-f5e234ef2016"), Type = TextBlockType.Text, Text = "The shield has Hardness 20." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("16525e18-0364-4490-af33-68e4416ae090"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8d167cd0-4120-4740-87c6-644868139951"), Type = TextBlockType.Text, Text = "The shield has Hardness 25." }
                }
            };
        }

        protected override IEnumerable<InlineAction> GetInlineActions()
        {
            yield return new InlineAction
            {
                Id = Guid.Parse("e33137c5-5b7e-4b3a-a5fa-6eb20441ca12"),
                Name = "Shield Block",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Trigger = "While you have your shield raised, you take damage from a physical attack.",
                Effect = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("df0d18c1-f249-4472-93b2-0f3af69a97a3"), Type = TextBlockType.Text, Text = "You place your shield to ward off a blow. Your shield prevents you from taking an amount of damage up to the shield's Hardness. You and the shield each take any remaining damage, possibly breaking or destroying the shield."},
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("09fffc24-3498-48f4-8dab-3e654cfffa70"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("81235a19-00d3-48e8-b479-e9149a14d805"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("bd4d9a1c-d447-4dfc-b4be-c57068503ed4"), Traits.Instances.Force.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd587801-0f1d-4f1f-8639-2b80402cb3cf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 368
            };
        }
    }
}
