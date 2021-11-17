using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VisionsOfDanger : Template
    {
        public static readonly Guid ID = Guid.Parse("6473f72f-e3e2-4376-ae87-a05bead11615");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Visions of Danger",
                Level = 7,
                Range = "500 feet.",
                Area = "30-foot burst.",
                Duration = "1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9da8b2d7-d553-4123-b778-de348cda1f26"), Type = TextBlockType.Text, Text = "An illusion of horrific creatures fills the spell’s area. The creatures look like Tiny swarming monsters with a specific appearance of your choice, such as Hellish flies or animated saw blades. The burst deals 8d8 mental damage (basic Will save) to each creature that’s inside the burst when it’s created, enters the burst, or starts its turn inside the burst. A creature that critically succeeds at its Will save can immediately attempt to disbelieve the illusion. A creature that tries to Interact with the monsters or observes one with a Seek action can attempt to disbelieve the illusion. Creatures that disbelieve the illusion take no damage from the illusion thereafter." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("4f567def-934f-4808-8d2f-957906b4f967"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c36825df-a768-454e-a4a2-665110e26e29"), Type = TextBlockType.Text, Text = "The mental damage increases by 1d8." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a922dba-ea56-43af-898b-dcf8809785f6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 381
            };
        }
    }
}
