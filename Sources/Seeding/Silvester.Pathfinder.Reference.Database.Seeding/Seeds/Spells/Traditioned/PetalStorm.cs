using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PetalStorm : Template
    {
        public static readonly Guid ID = Guid.Parse("4b246e82-cd38-4a1f-9fdb-f5dbe1232132");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Petal Storm",
                Level = 4,
                Range = "120 feet.",
                Duration = "1 minute.",
                Area = "15-foot radius burst.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71f19438-5f6e-4336-9090-c5a48849fff4"), Type = TextBlockType.Text, Text = "You bring forth a cloud of razor-sharp flower petals that thrash violently in the wind. A creature that enters the storm or starts its turn in the storm is sliced by the razor-sharp edges of the petals. It takes 2d10 slashing damage with a basic Reflex save. A creature can take damage from the petals only once per round. At the end of the duration, the storm calms and the petals fall harmlessly to the ground." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("bd13832b-7e0c-4549-be32-f6b8e2f60d59"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("2485a2b1-a971-4cf2-99db-56df26d66185"), Type = TextBlockType.Text, Text = "The damage increases by 1d10." }
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Plant.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dcd40ed0-f31d-45b6-9b71-4772adf7e694"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 121
            };
        }
    }
}
