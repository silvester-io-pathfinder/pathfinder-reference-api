using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MercilessRend : Template
    {
        public static readonly Guid ID = Guid.Parse("afc8cecf-b6db-4d4a-a98d-4bb2d76f7421");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Merciless Rend",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6dd0c001-ebad-4cfc-8cb8-d37a9774b8b8"), Type = TextBlockType.Text, Text = "Your eidolon rends its foes. It automatically deals the damage from its secondary attack to the enemy." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("952719b2-55ca-48ec-8b76-4f9ab918c9c6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
