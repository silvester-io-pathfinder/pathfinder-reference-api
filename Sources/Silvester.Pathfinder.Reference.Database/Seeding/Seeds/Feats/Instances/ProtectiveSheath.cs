using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ProtectiveSheath : Template
    {
        public static readonly Guid ID = Guid.Parse("017c086f-b833-4da9-9532-5ac31b59bb70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Protective Sheath",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d43d36d6-92b5-417a-92fb-31dcc073c562"), Type = TextBlockType.Text, Text = "When you lash out with your (item: clan dagger), you keep its sheath close at hand. When you use (feat: Clan’s Edge), if the hand you’re not holding the dagger with is empty, you can use your clan dagger’s sheath to block attacks as well. The circumstance bonus to your AC from parrying increases to a +2 against any target you hit with a (action: Strike) this turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2b850d8b-ca07-44dd-99fb-a008f43ec6ac"), Feats.Instances.ClansEdge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32ba3625-300b-4667-a7c1-ffd6a2ab1ba1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
