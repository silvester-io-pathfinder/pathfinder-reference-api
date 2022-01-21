using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HealingPlaster : Template
    {
        public static readonly Guid ID = Guid.Parse("6f6266ce-1586-4de2-a1bf-613c54916dd2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Healing Plaster",
                Level = 1,
                Range = "5 feet.",
                Duration = "10 minutes.",
                Targets = "A handful of dirt or mud.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8a33b652-8ba8-4094-bc71-d7e247e84376"), Type = TextBlockType.Text, Text = "You purify some dirt or mud into a pliable, claylike plaster that can aid in clotting and healing. This restorative substance can be used in lieu of healer�s tools for Medicine checks to Administer First Aid or Treat Wounds. If the plaster isn�t used within the spell�s duration, or if you Cast the Spell again before using the plaster, it reverts to being normal non-magical earth." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d0430752-0fa9-46d7-af1f-f1cacce73815"),
                Level = "3rd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("378f48f7-f609-4194-9b85-18b62187b85d"), Type = TextBlockType.Text, Text = "The plaster grants anyone using it to Administer First Aid or Treat Wounds a +1 item bonus to the Medicine check." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("92bb67cb-99fe-4209-adf8-3c89d21bd74e"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("dfc35854-7d85-4eb2-b7e4-9e89b53b38e2"), Traits.Instances.Earth.ID);
            builder.Add(Guid.Parse("cdd1b5b1-2831-4430-9154-f4f02214c028"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ad385f2-3c48-4553-bb6d-188051893998"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 109
            };
        }
    }
}
