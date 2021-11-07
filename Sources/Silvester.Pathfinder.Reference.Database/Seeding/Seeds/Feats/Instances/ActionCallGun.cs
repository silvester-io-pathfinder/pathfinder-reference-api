using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ActionCallGun : Template
    {
        public static readonly Guid ID = Guid.Parse("43d532ec-c773-476a-8066-cbe79e55dad5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Action - Call Gun",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b9168ce-6af4-4a70-b92b-3d9a6c76eb03"), Type = TextBlockType.Text, Text = "You hold aloft a free hand and call the firearm or crossbow you chose during your daily preparations into your hand. As long as the weapon you chose is on the same plane, it appears in your hand." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62dbe49f-b698-45a2-a246-ed086b4165b6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
