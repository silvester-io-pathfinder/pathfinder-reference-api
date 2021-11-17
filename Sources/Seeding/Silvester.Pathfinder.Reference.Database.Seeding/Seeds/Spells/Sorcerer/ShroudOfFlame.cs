using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShroudOfFlame : Template
    {
        public static readonly Guid ID = Guid.Parse("a80c3d92-2d5f-4df6-b112-65ad54aa428f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shroud of Flame",
                Level = 3,
                Area = "10-foot emanation.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47d93c59-7c55-4626-a694-b441c5558949"), Type = TextBlockType.Text, Text = "You encircle yourself in an aura of protective flames. Each creature that hits you with an unarmed attack, Grapples you, or otherwise touches you takes 3 fire damage. When you Cast the Spell and the first time you sustain it each round, each creature in the area takes 3d6 fire damage (basic Reflex save)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("42c8efa1-5d76-4ea8-9f81-932d2bdf9f71"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("47a75711-5352-45f9-b575-810a0630d8c7"), Type = TextBlockType.Text, Text = "The damage caused by touching you increases by 1, and the fire damage when you Cast the Spell or sustain it increases by 1d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad098c0a-4c69-40ad-b19a-d79c3042138f"),
                SourceId = Sources.Instances.Pathfinder168.ID,
                Page = 74
            };
        }
    }
}
