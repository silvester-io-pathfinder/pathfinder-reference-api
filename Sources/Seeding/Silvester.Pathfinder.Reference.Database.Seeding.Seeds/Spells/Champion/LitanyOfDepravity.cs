using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LitanyOfDepravity : Template
    {
        public static readonly Guid ID = Guid.Parse("0f2863be-3c17-450b-9197-a2e7e47d5127");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Litany of Depravity",
                Level = 7,
                Range = "30 feet.",
                Targets = "1 good creature.",
                Duration = "1 round.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Champion.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("75e05a10-b66f-4093-84d6-2bb6351f0b1f"), Type = TextBlockType.Text, Text = "Your litany calls into question the morals your foe claims to hold dear. The target gains weakness 7 to evil, then becomes temporarily immune to all your litanies for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("8b1c88fe-4e0a-4557-a28e-99fa46ae90cc"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b5d50b45-52ce-46c6-b242-95bd199828ae"), Type = TextBlockType.Text, Text = "The weakness increases by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("6c36ec77-e948-463b-b014-f6ee03269fe9"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7af18e8a-6ef0-4870-8466-1df25014e752"), Traits.Instances.Champion.ID);
            builder.Add(Guid.Parse("c42e8973-e6b0-49dc-b959-13d2f5f2a574"), Traits.Instances.Evil.ID);
            builder.Add(Guid.Parse("be2b3c97-240a-4272-823e-c7a01e9b0c12"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("13b24f00-c399-4fb6-91e6-ca5801ef42ad"), Traits.Instances.Litany.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7e3120b-e34a-4d0a-81cb-bc179c75359c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 228
            };
        }
    }
}
