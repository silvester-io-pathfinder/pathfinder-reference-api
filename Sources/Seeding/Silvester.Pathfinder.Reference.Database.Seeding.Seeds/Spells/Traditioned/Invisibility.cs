using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Invisibility : Template
    {
        public static readonly Guid ID = Guid.Parse("c70083c6-9775-40f9-81f9-dd222d99236c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Invisibility",
                Level = 2,
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6d318dcd-196c-4f8f-b038-0f2bfca4fd78"), Type = TextBlockType.Text, Text = "Cloaked in illusion, the target becomes invisible. This makes it undetected to all creatures, though the creatures can attempt to find the target, making it hidden to them instead (page 466). If the target uses a hostile action, the spell ends after that hostile action is completed." };
        }

     
        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("27d38403-310a-4748-af34-743e7a6705ee"), 
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7e74161d-9220-468e-82bc-c57ea0f8147c"), Type = TextBlockType.Text, Text = "The spell lasts 1 minute, but it doesn't end if the target uses a hostile action." }
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ba6c9b08-7070-4618-bdc7-29a2e07bfb0a"), Traits.Instances.Illusion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36e0d8e4-1515-4cb7-816c-b5890d0d4209"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 347
            };
        }
    }
}
