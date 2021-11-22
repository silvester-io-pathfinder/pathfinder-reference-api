using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PhantomPrison : Template
    {
        public static readonly Guid ID = Guid.Parse("3cc4ea93-1668-471e-8345-81f63fa10487");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Phantom Prison",
                Level = 3,
                Range = "50 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("358d0d1e-fbfe-45bc-b516-84ddff0abda6"), Type = TextBlockType.Text, Text = "You completely surround a Large or smaller creature in immobile illusory walls, trapping it inside a false prison it can�t escape. No other creatures see or feel these walls, and the target can�t see anything outside of the illusory walls. The target can attempt a Will save when the spell is cast, each time it attempts to interact with or escape the walls, and each time something from outside the walls affects the target. On a success, it disbelieves the illusion and the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("be2a74cf-4bc1-46d2-9e56-af078fa3b1d3"),
                Level = "8th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("f95633be-53cd-404a-b295-1ec9f02f9cfa"), Type = TextBlockType.Text, Text = "You can target up to 5 creatures." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b3522f5-d98b-47f0-8fb4-f74ab42414da"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 121
            };
        }
    }
}
