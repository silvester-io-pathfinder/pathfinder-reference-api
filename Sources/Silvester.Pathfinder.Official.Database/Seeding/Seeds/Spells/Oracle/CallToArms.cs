using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CallToArms : Template
    {
        public static readonly Guid ID = Guid.Parse("bb25bf00-0614-4a04-838d-0d3a53149a13");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Call to Arms",
                Level = 1,
                Area = "20-foot emanation.",
                Trigger = "You are about to roll for initiative.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70688af2-20e4-487a-ac58-8c908ac3cb6f"), Type = TextBlockType.Text, Text = "You cry out a call to arms, inspiring your allies to enter the fray. Each ally in the area gains a +2 status bonus to their initiative roll and gains temporary Hit Points equal to the spell’s level; these temporary Hit Points last for the spell’s duration." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a9b788d7-6183-41ad-8b02-231d9732a9bb"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0229de67-af33-469f-ae28-434bb544870c"), Type = TextBlockType.Text, Text = "The bonus increases to +3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("baba742d-9871-4c96-9dc6-154101706231"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("efed7397-c6e5-4c7f-b039-4c8e9041e6cf"), Type = TextBlockType.Text, Text = "The bonus increases to +4." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a5557a4-658f-4dc1-b8a2-0e8dd96ed371"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 230
            };
        }
    }
}
