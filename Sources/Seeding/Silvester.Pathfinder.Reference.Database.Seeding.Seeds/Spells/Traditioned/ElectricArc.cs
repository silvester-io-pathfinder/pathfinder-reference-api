using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ElectricArc : Template
    {
        public static readonly Guid ID = Guid.Parse("927d7988-999b-4c72-a7bd-63abe7d2d0b5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Electric Arc",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 or 2 creatures.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7e84d2e4-544f-4ef7-be5e-f53273ab7576"), Type = TextBlockType.Text, Text = "An arc of lightning leaps from one target to another. You deal electricity damage equal to 1d4 plus your spellcasting ability modifier." };
        }


        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6f1232d6-ec06-448d-847f-95ff79af2503"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("876316b5-2c99-44ad-be49-9fae9ee33c25"), Type = TextBlockType.Text, Text = "The damage increases by 1d4." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b6e35686-2701-4fc9-b196-ace1c6c41556"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("08108027-0e4a-46ce-abfd-2afa52b94fb1"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("144c537b-a48d-41bf-85d2-a9d24d49d380"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b506bf5f-9c30-4b29-b0cd-6f8b5092c289"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 335
            };
        }
    }
}
