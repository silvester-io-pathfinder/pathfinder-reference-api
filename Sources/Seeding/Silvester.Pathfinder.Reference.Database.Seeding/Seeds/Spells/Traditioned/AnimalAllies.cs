using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AnimalAllies : Template
    {
        public static readonly Guid ID = Guid.Parse("d69d73da-4242-4aed-8c5c-832459117356");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Animal Allies",
                Level = 1,
                Area = "5-foot emanation.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9450c8e-d3f0-4233-b857-6ad9e91e5855"), Type = TextBlockType.Text, Text = "You summon tiny, ordinary animals from the environment, such as insects, birds, or fish, to quickly lash out at nearby foes. The animals swarm around the creatures in the area, dealing each of them 3d4 piercing damage with a basic Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e456ef91-59e7-4f97-bf56-b526108b014d"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("86e2d3c7-0170-49f8-93c8-06c6400df595"), Type = TextBlockType.Text, Text = "The damage increases by 3d4." }
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
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af32033b-9927-4166-8770-ea77f561b8bb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 89
            };
        }
    }
}
