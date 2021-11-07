using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatfolkWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("f7e34475-6f8b-4280-9d01-6a59a5dd9720");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catfolk Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("aecea53d-a556-4561-a06a-adbcd38c16d4"), Type = TextBlockType.Text, Text = "You favor weapons that you can use with quick, darting slashes like a cat&#39;s claws. You are trained with the hatchet, kama, kukri, scimitar, and sickle. In addition, you gain access to kama, kukris, and all uncommon catfolk weapons. For you, martial catfolk weapons are simple weapons and advanced catfolk weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db2cc8f9-d6c6-42e9-a70d-b0944a9cf59a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
