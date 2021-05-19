using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class MirrorImage : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mirror Image",
                Level = 2,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Three illusory images of you swirl about your space, potentially causing those who attack you to hit one of the images instead of you. Any attack that would hit you has a random chance of hitting one of your images instead of you. If all three images remain, there is a 1 in 4 chance of hitting you (1 on 1d4). With two images remaining, there is a 1 in 3 chance of hitting you (1–2 on 1d6). With only one image, the chances are 1 in 2 (1–3 on 1d6)." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Once an image is hit, it is destroyed. If an attack roll fails to hit your AC but doesn’t critically fail, it destroys an image but has no additional effect (even if the attack would normally have an effect on a failure). If an attack roll is a critical success and would hit one of the images, one of the images is destroyed and the attack roll becomes a success against you. Once all the images are destroyed, the spell ends." };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 352
            };
        }
    }
}
