using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MalignantSustenance : Template
    {
        public static readonly Guid ID = Guid.Parse("c65f18e1-0073-486d-bc04-4793f8539bae");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Malignant Sustenance",
                Level = 4,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 willing undead creature.",
                DomainId = Domains.Instances.Undeath.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ce9640b-20df-4548-a55e-427148d7ff52"), Type = TextBlockType.Text, Text = "You embed a seed of negative energy in an undead creature, restoring its unnatural vigor. The target gains fast healing 7. This healing comes from negative energy, so it heals the undead rather than damaging it." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("78e211a7-9094-41f1-a44e-26751267f21f"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f8e823d9-29e6-4d4c-9bec-b2f5f8274942"), Type = TextBlockType.Text, Text = "The fast healing increases by 2." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("4045a130-da44-4cfd-85a1-56d59dbf1c12"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b0159501-48a2-46e9-b823-86199ccd9232"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("08f1410f-ef95-4f66-a9ac-93aab96dd06b"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("17b26280-cd72-4946-8173-e27d899020ec"), Traits.Instances.Negative.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0cf0af5e-cff9-430a-b8ee-dff0e210a9fa"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 394
            };
        }
    }
}
