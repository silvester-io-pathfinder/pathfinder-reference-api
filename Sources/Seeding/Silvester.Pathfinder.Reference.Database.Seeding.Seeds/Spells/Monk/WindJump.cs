using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WindJump : Template
    {
        public static readonly Guid ID = Guid.Parse("4fce97c0-4714-4c52-a6a3-8e044af502c4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wind Jump",
                Level = 5,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
           yield return new TextBlock { Id = Guid.Parse("0f014427-4fe8-49c6-b0d8-fd0829f9ade2"), Type = TextBlockType.Text, Text = "You gain a fly Speed equal to your Speed. You must end your turn on solid ground, or you fall." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7ad6e589-73fd-47e8-b3a3-dd048a2c5374"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0e2d5fc4-bc4c-4965-861b-afeeb609d66b"), Type = TextBlockType.Text, Text = "At the end of your turn, you can attempt a DC 30 Acrobatics check to find purchase in midair. If you succeed, you don't fall." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1d1e8db2-0625-4136-a79e-fc3b332039dd"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("6874c774-76d5-42b9-adf3-b4a5ca10b8f4"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("4a26745f-774a-4a9a-8128-02360eb6a41d"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("c5a0606e-ed96-4f81-9edf-2070779d3c87"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d61a473-016a-4008-b652-e22b74eec9a6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 402
            };
        }
    }
}
