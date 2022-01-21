using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DragonWings : Template
    {
        public static readonly Guid ID = Guid.Parse("f170eec2-9c80-4ac2-a25e-bf347b06c095");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dragon Wings",
                Level = 5,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("161d3313-a15e-4985-aab9-b6f4d582d4e7"), Type = TextBlockType.Text, Text = "Leathery wings sprout from your back, giving you a fly Speed of 60 feet or your Speed, whichever is faster. When this spell's duration would end, if you're still flying, you float to the ground, as feather fall. You can increase the Focus Point cost by 1 to gain the effects of dragon claws as long as the wings last." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("bd8ebfd6-761a-470b-8531-f30695da5c80"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("dccdcdfd-3586-4b96-9f28-468776f04c8e"), Type = TextBlockType.Text, Text = "The duration increases to 10 minutes." }
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
            builder.Add(Guid.Parse("5c499078-33c1-4e2a-9c44-e61dc265f9a3"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b684adb9-2cc0-45a0-8ba1-79f4ccbd22e1"), Traits.Instances.Morph.ID);
            builder.Add(Guid.Parse("dac0c0bd-fd7a-4cfd-8168-bd69e3755beb"), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse("491d9199-9906-448d-827f-76de760de0b9"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4377ae8b-6005-4d7d-8cad-e667831e314d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 403
            };
        }
    }
}
