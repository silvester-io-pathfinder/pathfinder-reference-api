using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Sorcerer.Instances
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
            yield return new TextBlock { Id = Guid.Parse("b2e74c60-17da-4539-861a-08e2e962fb39"), Type = TextBlockType.Text, Text = "Ground in the area turns swampy and fetid. The area is difficult terrain. The sludge at the bottom of the morass animates into diminutive sludge beasts that have a demonic appearance. These don’t function as normal creatures, but they swarm over creatures in the swamp and exude a noxious stench. The swamp deals 1d6 poison damage; creatures that end their turn in the area must attempt a basic Fortitude save. You can increase the number of actions it takes to Cast the Spell. For each additional action, increase the burst’s radius by 5 feet." };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Olfactory.ID;
            yield return Traits.Instances.Sorcerer.ID;
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
