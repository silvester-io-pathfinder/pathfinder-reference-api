using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationSubtleDampeners : Template
    {
        public static readonly Guid ID = Guid.Parse("e00e281a-7bb6-4645-8e68-d4d40de11441");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Subtle Dampeners",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad68bc09-8af7-4e06-9e6c-ed636cd03a56"), Type = TextBlockType.Enumeration, Text = "*Subterfuge Suit Only**" };
            yield return new TextBlock { Id = Guid.Parse("726d605f-2cb8-4335-938f-78dcc677188e"), Type = TextBlockType.Text, Text = "You’ve designed your armor to help you blend in and dampen noise slightly. When you send your armor into overdrive, the dampeners increase their effect, improving your Stealth. When under the effects of (action: Overdrive), you gain a +1 circumstance bonus to Stealth checks. If you’re a master in Crafting, this increases to a +2 circumstance bonus." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("061a3c0a-100b-4edd-89b7-46c9c31e4b3a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
