using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TanglingCreepers : Template
    {
        public static readonly Guid ID = Guid.Parse("a6a3e6b3-df80-4fa9-8875-a7c960e61b39");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tangling Creepers",
                Level = 6,
                Range = "500 feet.",
                Area = "40-foot burst.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59b2ea93-6ebb-4fdb-bcbf-ccedf43f774e"), Type = TextBlockType.Text, Text = "Dense, twitching creepers sprout from every surface and fill any bodies of water in the area. Any creature moving on the land, or Climbing or Swimming within the creepers, takes a –10-foot circumstance penalty to its Speeds while in the area. Once per round, you can make a vine lash out from any square within the expanse of creepers by using a single action, which has the concentrate trait. This vine has a 15-foot reach. Make a melee spell attack roll against the target; on a success, the vine pulls the target into the creepers and makes it immobilized for 1 round or until the creature Escapes (against your spell DC), whichever comes first." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0c6218b1-ad99-4bb9-a349-001cb34fe42c"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("d17bbee7-82c1-4905-a271-739ed1566956"), Traits.Instances.Plant.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39caced3-1afe-4561-b926-a5715bd391ab"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 377
            };
        }
    }
}
