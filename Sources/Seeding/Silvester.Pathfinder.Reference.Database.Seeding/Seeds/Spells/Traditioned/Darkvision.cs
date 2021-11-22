using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Darkvision : Template
    {
        public static readonly Guid ID = Guid.Parse("66172098-6cdb-4587-89bb-24fe1a8faf7c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Darkvision",
                Level = 2,
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c9a23b3f-b2ed-40b3-87cc-431369d6297a"), Type = Utilities.Text.TextBlockType.Text, Text = "You grant yourself supernatural sight in areas of darkness. You gain darkvision." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b2fd64f9-51d7-42fb-b78d-fd29bf47f508"), 
                Level = "3rd", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("12971af1-dc37-4275-8caa-f1b40df0c206"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell's range is touch and it targets 1 willing creature." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("3d32cc67-f66b-4b7d-a267-ff050108114c"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("58b96894-4f49-442f-977c-482e7dd65f1c"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell's range is touch and it targets 1 willing creature.The duration is until the next time you make your daily preparations." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50ee6a49-94b5-4916-b00d-7f242fcf60fb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 327
            };
        }
    }
}
