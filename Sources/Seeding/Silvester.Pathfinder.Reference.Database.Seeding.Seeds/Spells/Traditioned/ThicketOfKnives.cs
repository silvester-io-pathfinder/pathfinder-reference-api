using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ThicketOfKnives : Template
    {
        public static readonly Guid ID = Guid.Parse("c288807a-3ed9-490e-a97a-1605ecd8b831");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Thicket of Knives",
                Level = 1,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c312cb33-ff2e-41e1-810a-974030beced9"), Type = TextBlockType.Text, Text = "You create numerous phantom copies of your weapon arm, hiding your true movements and rendering your attacks unpredictable. You gain a +2 status bonus to Deception checks. If you�re untrained in Deception, you can use the Feint action anyway, and add your level as your proficiency bonus despite being untrained." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2283148e-1c75-48e7-9b00-27cbc03af2f5"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("f212294e-2ac5-43c9-a5af-51df18229476"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("456547b4-23d7-42ee-a9c2-d408880b8999"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 136
            };
        }
    }
}
