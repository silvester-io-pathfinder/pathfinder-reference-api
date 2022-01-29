using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InvokeTrueName : Template
    {
        public static readonly Guid ID = Guid.Parse("92a86d32-e88c-4b33-9f3b-6c684c119461");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Invoke True Name",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature whose true name you know.", 
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19025ba6-816d-471b-a489-84e75f616ce4"), Type = TextBlockType.Text, Text = "You speak the true name of a creature to more surely affect it with your magic. Until the end of the current turn, the target is flat-footed against your spells and takes a -2 circumstance penalty to saving throws against your spells. In addition, the first time this turn the target takes damage from one of your spells, it has weakness to that damage equal to double the level of invoke true name." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("1c63d104-b12f-4ff5-9773-1365093891ac"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("6737fa56-b3df-4782-89a0-25d0769436e9"), Type = TextBlockType.Text, Text = "" }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2603e8da-7f53-4a45-b199-2d2bf6c12652"), Traits.Instances.Chaotic.ID);
            builder.Add(Guid.Parse("0d9c727c-2edd-43f0-af39-eb368a94c1bd"), Traits.Instances.Disease.ID);
            builder.Add(Guid.Parse("d84dbff7-d6a2-42d1-b667-86f510fabc6b"), Traits.Instances.Evil.ID);
            builder.Add(Guid.Parse("edf852d1-3e2e-4827-992a-e72875eff188"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("051fe3ec-359a-4aa6-8b15-e51ef67d812c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 247
            };
        }
    }
}