using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SwampOfSloth : Template
    {
        public static readonly Guid ID = Guid.Parse("d8dd0aaa-37e1-4196-babb-23edb266f372");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Swamp of Sloth",
                Level = 3,
                Range = "120 feet.",
                Area = "5-foot burst or more.",
                Duration = "1 minute.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b2e74c60-17da-4539-861a-08e2e962fb39"), Type = TextBlockType.Text, Text = "Ground in the area turns swampy and fetid. The area is difficult terrain. The sludge at the bottom of the morass animates into diminutive sludge beasts that have a demonic appearance. These don't function as normal creatures, but they swarm over creatures in the swamp and exude a noxious stench. The swamp deals 1d6 poison damage; creatures that end their turn in the area must attempt a basic Fortitude save. You can increase the number of actions it takes to Cast the Spell. For each additional action, increase the burst's radius by 5 feet." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2f2f650b-08ca-4d66-9d29-e5d50961a93a"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("1528f257-6f10-49cc-8089-acb4e8328b86"), Type = TextBlockType.Text, Text = "The damage increases by 1d6, and the initial radius increases by 5 feet." }
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
            builder.Add(Guid.Parse("5ac0102f-3404-47c3-a3a1-201a5e965768"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b629a9f0-7a16-426d-ac09-ce50d613d123"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("8d2cea48-4e5e-4ccf-b655-ab6cc43e40dc"), Traits.Instances.Olfactory.ID);
            builder.Add(Guid.Parse("c010851b-c826-4f29-aa4c-3886bb620c0e"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adcecec7-efb5-45aa-a517-14271d4fd5ec"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 405
            };
        }
    }
}