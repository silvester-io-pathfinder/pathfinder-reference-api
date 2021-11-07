using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShroudedMien : Template
    {
        public static readonly Guid ID = Guid.Parse("dcf9ce7b-86be-489b-b52d-8934e6b12e01");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shrouded Mien",
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
            yield return new TextBlock { Id = Guid.Parse("6b9c813e-d0ce-45f0-bf26-122759747634"), Type = TextBlockType.Text, Text = "You’re used to dealing with dangerous situations and sinister creatures. You become trained in Deception (or another skill of your choice, if you’re already trained in Deception), and you gain the (feat: Lengthy Diversion) skill feat as a bonus feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("852ed81a-58c2-4537-bda0-80486987b1c0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
