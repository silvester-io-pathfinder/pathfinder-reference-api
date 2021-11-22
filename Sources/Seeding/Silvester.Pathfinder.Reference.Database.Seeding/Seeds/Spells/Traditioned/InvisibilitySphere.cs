using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InvisibilitySphere : Template
    {
        public static readonly Guid ID = Guid.Parse("01e7386b-81a0-4b7b-81dc-1ae9bab7a439");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Invisibility Sphere",
                Level = 3,
                Range = "10 minutes.",
                Area = "10-foot emanation.",
                Duration = "10 minutes.",
                Targets = "You and any number of creatures in range.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("129be4c7-9d5f-4d05-a66e-bffd1031ea3d"), Type = TextBlockType.Text, Text = "You and all targets are invisible except to each other as long asyou remain within the spell's area. If a creature made invisible by this spell leaves the spell's area, it becomes visible and remains so even if it returns to the spell's area. If any creature made invisible by this spell uses a hostile action, the spell ends after the hostile action is completed." };
            yield return new TextBlock { Id = Guid.Parse("00133eb4-6fd3-44d9-9ae4-352539d6c817"), Type = TextBlockType.Text, Text = "While exploring, it's easy to move together slowly and remain invisible. This is untenable in a battle, however. Once an encounter begins, creatures remain invisible until at most the end of the first round, at which point the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0361fb75-7acb-416b-bea6-018fb175cc95"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("dd3d0d9d-1695-4ad0-9dc5-7709381c542c"), Type = TextBlockType.Text, Text = "The duration increases to 1 hour." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
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
                Id = Guid.Parse("fd39d222-743f-402a-baad-3cca2f092c5e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 347
            };
        }
    }
}
