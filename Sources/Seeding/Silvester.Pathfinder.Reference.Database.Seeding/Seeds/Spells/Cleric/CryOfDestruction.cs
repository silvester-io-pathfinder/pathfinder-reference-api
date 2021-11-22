using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CryOfDestruction : Template
    {
        public static readonly Guid ID = Guid.Parse("799acd96-bf9f-44ea-b9e0-fb0adf452fd2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cry of Destruction",
                Level = 1,
                Area = "15-foot cone.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DomainId = Domains.Instances.Destruction.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d3c13bb-010a-49fd-97d5-b0abb0fdcd7a"), Type = TextBlockType.Text, Text = "Your voice booms, smashing what's in front of you. Each creature and unattended object in the area takes 1d8 sonic damage. If you already dealt damage to an enemy this turn with a Strike or spell, increase the damage dice from this spell to d12s." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e344cc5a-cd12-410a-b7f7-dc604afce231"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f706c53b-2285-4899-97b0-383fdbe417cd"), Type = TextBlockType.Text, Text = "The damage increases by 1d8." }
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
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Sonic.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81411723-d668-4e46-b43a-cb4cab4d3628"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 390
            };
        }
    }
}
