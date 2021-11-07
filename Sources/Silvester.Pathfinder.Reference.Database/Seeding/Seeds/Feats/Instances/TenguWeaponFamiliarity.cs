using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenguWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("d3f8dde1-a37b-4b67-8335-4aaa73fa4bd4");

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
            yield return new TextBlock { Id = Guid.Parse("066ac9b0-334d-46cd-abd9-b4f462c0e16c"), Type = TextBlockType.Text, Text = "You&#39;ve trained with a blade and other tengu weapons ever since you hatched. You gain access to khakkaras. Additionally, choose two weapons from the sword group. You can choose from among all common martial swords, plus the katana, temple sword, and wakizashi. For the purpose of determining your proficiency, that weapon is a simple weapon, and if the weapon isn&#39;t common, you gain access to it. If you are trained in all martial weapons, you add common advanced swords to the swords you can choose from." };
            yield return new TextBlock { Id = Guid.Parse("a330665b-eb12-468c-9aaa-e67e54d62579"), Type = TextBlockType.Text, Text = "You also gain access to all uncommon tengu weapons. For the purpose of determining your proficiency, martial tengu weapons are simple weapons, and advanced tengu weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21114cfd-732f-42c6-aa19-4dbc2314ccfb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
