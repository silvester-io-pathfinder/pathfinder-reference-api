using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VampiricExsanguination : Template
    {
        public static readonly Guid ID = Guid.Parse("2464670c-7c98-4fc8-9489-b1aeaf23ba8f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Vampiric Exsanguination",
                Level = 6,
                Area = "30-foot cone",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c94c47e7-9583-478a-99c3-b338ca02df20"), Type = TextBlockType.Text, Text = "You draw in the blood and life force of other creatures through your outstretched arms. You deal 12d6 negative damage to living creatures in the area." };
            yield return new TextBlock { Id = Guid.Parse("72a6ea55-0958-44e4-9f97-ac092f7072bb"), Type = TextBlockType.Text, Text = "You gain temporary Hit Points equal to half the damage a single creature takes from this spell; calculate these temporary Hit Points using the creature that took the most damage. You lose any remaining temporary Hit Points after 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0b4bfbe3-d036-4bac-b5be-20ea069c2087"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("284b9bff-b03a-4dd2-9277-8a733dd4c58f"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("4c1f24d0-3c09-4402-853b-0dbb974847c3"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("77da5cc4-3b9a-4a1d-a959-eb0c84e50104"), Traits.Instances.Death.ID);
            builder.Add(Guid.Parse("5d22f69f-d1d0-4f00-ba44-5e6d10979c83"), Traits.Instances.Negative.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1c20e82-c00a-49c5-b9a5-a19f2667012b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 380
            };
        }
    }
}
