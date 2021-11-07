using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmoredRebuff : Template
    {
        public static readonly Guid ID = Guid.Parse("6a028058-9366-417f-8134-f58896755349");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armored Rebuff",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An adjacent foe critically fails an attack roll to Strike you with a melee weapon or unarmed attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42a31ef9-08c1-490c-9786-30cb51ffaddb"), Type = TextBlockType.Text, Text = "You rebuff puny attacks with your armor, knocking back your foe. Attempt an Athletics check to (action: Shove) the triggering foe, even if you don’t have a hand free. If you succeed, you can’t (action: Stride) to follow the foe, as you’re knocking the foe back with the rebounded attack, not by physically moving towards them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("40934a6b-4c94-412f-8772-ef1f6547d78d"), Feats.Instances.SentinelDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba6653a8-69a5-49eb-aaa9-2792dc49f6e6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
