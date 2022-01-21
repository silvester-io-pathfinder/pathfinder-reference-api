using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FaceInTheCrowd : Template
    {
        public static readonly Guid ID = Guid.Parse("5a4ec9f8-4e49-47e2-8cbc-6cc766759271");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Face in the Crowd",
                Level = 1,
                Duration = "1 minute.",
                DomainId = Domains.Instances.Cities.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9ee01086-1ee3-4d80-889e-97e4cc73ca20"), Type = TextBlockType.Text, Text = "While in a crowd of roughly similar creatures, your appearance becomes bland and nondescript. You gain a +2 status bonus to Deception and Stealth checks to go unnoticed among the crowd, and you ignore difficult terrain caused by the crowd." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("116234df-eb0c-4cca-aef1-85a9f35c15d4"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c3f427b7-0fcb-4bce-98a3-e2b79197d677"), Type = TextBlockType.Text, Text = "The spell gains a range of 10 feet and can target up to 10 creatures." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("35e504ea-5ce2-4b1d-ae8e-25a1c478134a"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("09b74838-61b6-4ce5-a705-9c79c55e71d4"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("1d679859-b2ef-4850-8ea2-a18acaffffc7"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("e52be123-75b5-4940-9cb2-0945241af7b4"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b05635d-ceb7-468e-9f2a-020d4547b782"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 392
            };
        }
    }
}
