using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalflingWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("b80f79c9-01e3-4a71-a440-ced2cb23589e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halfling Weapon Familiarity",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81e7830f-9591-44a2-b72d-bd8d1edc1a92"), Type = TextBlockType.Text, Text = $"You favor traditional halfling weapons, so you've learned how to use them more effectively. You have the trained proficiency with the sling, halfling sling staff, and shortsword." };
            yield return new TextBlock { Id = Guid.Parse("4bc5f2bc-c26d-4a40-8ae9-ea75f0f0bd14"), Type = TextBlockType.Text, Text = $"In addition, you gain access to all uncommon halfling weapons. For the purpose of determining your proficiency, martial halfling weapons are simple weapons and advanced halfling weapons are martial weapons." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fa0e03e-3789-4743-80ac-b550d3ecc0ad"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
