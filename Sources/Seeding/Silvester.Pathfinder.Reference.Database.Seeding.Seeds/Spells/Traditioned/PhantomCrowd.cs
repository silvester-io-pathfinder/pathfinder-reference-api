using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PhantomCrowd : Template
    {
        public static readonly Guid ID = Guid.Parse("13d6737f-d69e-4d54-98f9-c22840011f23");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Phantom Crowd",
                Level = 2,
                Range = "60 feet.",
                Duration = "Sustained up to 10 minutes.",
                Area = "A 10-foot sqaure.",
                CastTime = "",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("33637782-f821-4f1f-9de3-b94956f1e4d3"), Type = TextBlockType.Text, Text = "A tightly packed crowd of humanoids appropriate to the area appear, facing you and agreeing loudly with anything you say. A creature that touches a member of the crowd or makes a Seek action to examine the crowd can attempt to disbelieve your illusion. The crowd is difficult terrain for anyone who hasn't disbelieved the illusion." };
            yield return new TextBlock { Id = Guid.Parse("b3748db6-1b71-4945-9731-7c29daea0dd1"), Type = TextBlockType.Text, Text = "When you spend 1 or more actions to cast a composition spell (Core Rulebook 386) or to perform an activity that includes a Performance check, you can also Sustain this Spell as part of that action." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ac1dc56e-62af-4c18-886e-d1fb2e509e8f"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("9b2b2370-16a8-428c-a68e-768ca5727663"), Type = TextBlockType.Text, Text = "The crowd occupies an additional 10-foot square in range. The additional square doesn't need to be adjacent to any other square created by the spell. It can overlap, but there's no additional effect in the overlapped squares." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("57be5a1a-a996-45ad-83ab-ab805276a31b"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("8a594062-1762-4b0c-bc3e-b8501936c837"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32175ded-85a5-465c-a08a-e78e3c734c5c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 121
            };
        }
    }
}
