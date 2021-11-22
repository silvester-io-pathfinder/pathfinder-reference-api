using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class StrangeGeometry : Template
    {
        public static readonly Guid ID = Guid.Parse("378b0c20-9a8b-43cb-a1c6-b669b301dbdf");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Strange Geometry",
                Level = 5,
                Range = "60 feet.",
                Area = "4 cubes, each 10 feet on a side.",
                Targets = "",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("37a716cd-2455-4801-b4a8-686e3be2c13a"), Type = TextBlockType.Text, Text = "You cause the areas to appear to swell, bend, and break, twisting together in a bizarre spatial geometry. The cubes of the spell's area can't be adjacent to one another. A creature must attempt a Will save if it's in one of the cubes when you Cast the Spell, or if it later enters one of the areas, with the following effects. A creature interacting with the illusion can also attempt a Will save to disbelieve the illusion, as normal." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("334c8395-9147-4d5e-a857-e91f361b5797"),
                Success = "The creature disbelieves the illusion.",
                Failure = "All terrain in the cubes is difficult terrain for the creature, including the air if the creature is flying, walls if it's climbing, and so on. When the creature would exit one of the cubes, it exits from one randomly determined by the GM. This is a teleportation effect. It can exit from any edge of that cube it chooses. When selecting a random cube, the GM excludes any that don't match the creature's terrain; for instance, if the creature were exiting along the ground, the GM would exclude any cube that didn't have an exit on the ground.",
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa23c247-8af5-4b43-b28a-a464a5cad073"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 226
            };
        }
    }
}
