using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SupremeSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("e9bd2c80-2b6f-4fd4-b05d-7c6898007808");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Supreme Spellstrike",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa1f1f09-88c0-4b23-9452-c170c93814f8"), Type = TextBlockType.Text, Text = "You’ve made it almost effortless to combine spells and attacks. You’re permanently quickened. You can use your extra action only to (action: Strike) or to recharge (feat: Spellstrike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e5d9d053-4995-412f-a2ba-c4c0790adecf"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be70b75f-b8f0-48da-a594-c8a6dc7619f7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
