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
    public class TenguWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("6e3f410f-9a12-48eb-92a6-79e85553cdae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tengu Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("56a4380d-34c0-4e61-bbcb-5ecfb34b920f"), Type = TextBlockType.Text, Text = $"You've trained with a blade and other tengu weapons ever since you hatched. You gain access to khakkaras. Additionally, choose two weapons from the sword group. You can choose from among all common martial swords, plus the katana, temple sword, and wakizashi. For the purpose of determining your proficiency, that weapon is a simple weapon, and if the weapon isn't common, you gain access to it. If you are trained in all martial weapons, you add common advanced swords to the swords you can choose from." };
            yield return new TextBlock { Id = Guid.Parse("96d59b6c-cccf-41c4-b248-c2b4704d85a7"), Type = TextBlockType.Text, Text = $"You also gain access to all uncommon tengu weapons. For the purpose of determining your proficiency, martial tengu weapons are simple weapons, and advanced tengu weapons are martial weapons." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03b4406c-6aeb-4a29-971f-1d76d5acb6ca"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
