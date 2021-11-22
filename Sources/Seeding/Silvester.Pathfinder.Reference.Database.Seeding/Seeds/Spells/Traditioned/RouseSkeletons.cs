using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RouseSkeletons : Template
    {
        public static readonly Guid ID = Guid.Parse("6eae41d2-3b05-4833-b069-bfb3830ae6e7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Rouse Skeletons",
                Level = 3,
                Range = "60 feet.",
                Duration = "Sustained up to 1 minute.",
                Area = "10-foot burst.",
                IsDismissable = true,
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31d435b1-2e45-43c3-b99b-596891bf32c8"), Type = TextBlockType.Text, Text = "Misshapen skeletal forms erupt from a solid surface, such as a stone floor, and fill the burst. The area they fill is difficult terrain. Their grasping claws deal 2d6 slashing damage to creatures on the ground in the area when the skeletons first appear (basic Reflex save)." };
            yield return new TextBlock { Id = Guid.Parse("1bd27cdc-e1de-4235-a6c6-b0eeadbc5ce1"), Type = TextBlockType.Text, Text = "On subsequent rounds, the first time you Sustain the Spell each round, you can move the area of skeletons up to 20 feet within the range of the spell and deal 2d6 slashing damage (basic Reflex save) to each creature in their new area." };
            yield return new TextBlock { Id = Guid.Parse("d14aec8f-a0f3-43b9-9c11-49e67b02a867"), Type = TextBlockType.Text, Text = "Damaging or destroying the skeletons is irrelevant, as new bones pull forth from the ground to repair and replace any that are obliterated." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2d27f943-25bc-4f4c-ad93-ff067df8dfd7"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("eecc2a04-4009-40f6-b7a9-4f877ade82be"), Type = TextBlockType.Text, Text = "The damage increases by 1d6." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c418d3a4-9623-4aae-84aa-b7a6abc900e6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 126
            };
        }
    }
}
