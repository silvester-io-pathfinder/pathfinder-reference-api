using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HydraulicTorrent : Template
    {
        public static readonly Guid ID = Guid.Parse("0808337e-3acb-4275-ab1c-50ded0240984");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hydraulic Torrent",
                Level = 4,
                Area = "60-foot line.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("004690f2-010d-4c71-98e1-aedf82b45e2f"), Type = TextBlockType.Text, Text = "A swirling torrent of water manifests along a straight line, battering creatures and unattended objects in its path and possibly pushing them away from you. The torrent deals 8d6 bludgeoning damage. Each creature in the area must attempt a basic Fortitude save; unattended objects automatically fail. Creatures and objects that fail the save are also knocked back 5 feet (10 feet on a critical failure)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9f6a9758-fe0e-4f9d-b24d-15ba72528465"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("708106df-fd45-4701-bb9e-52bbdbf51501"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("5c47fc62-5b53-4072-9446-6d684d097369"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("6de3c4e6-9287-4503-ab0a-902b5c1c1b5b"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("544b3305-7b58-4d71-b9cc-fd2c976fbd64"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 344
            };
        }
    }
}
