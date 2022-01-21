using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MirrorImage : Template
    {
        public static readonly Guid ID = Guid.Parse("83a9e5eb-3f02-4ffd-9d35-82f3308de234");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mirror Image",
                Level = 2,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb288801-5e30-44ec-8646-2e89a4197e05"), Type = TextBlockType.Text, Text = "Three illusory images of you swirl about your space, potentially causing those who attack you to hit one of the images instead of you. Any attack that would hit you has a random chance of hitting one of your images instead of you. If all three images remain, there is a 1 in 4 chance of hitting you (1 on 1d4). With two images remaining, there is a 1 in 3 chance of hitting you (1–2 on 1d6). With only one image, the chances are 1 in 2 (1–3 on 1d6)." };
            yield return new TextBlock { Id = Guid.Parse("e1f4ca9b-3600-42fd-8382-d6677a3b8fd2"), Type = TextBlockType.Text, Text = "Once an image is hit, it is destroyed. If an attack roll fails to hit your AC but doesn't critically fail, it destroys an image but has no additional effect (even if the attack would normally have an effect on a failure). If an attack roll is a critical success and would hit one of the images, one of the images is destroyed and the attack roll becomes a success against you. Once all the images are destroyed, the spell ends." };
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
            builder.Add(Guid.Parse("fb20430f-18d4-4367-b267-b4d930d48be8"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("384d4e62-4c04-4ec9-bb87-876552cbabff"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9042c54b-c9c7-48c9-84f2-92f877b9727d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 352
            };
        }
    }
}
