using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Unseat : Template
    {
        public static readonly Guid ID = Guid.Parse("09e6d410-9939-401c-85cd-7cf1705e0c14");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unseat",
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
            yield return new TextBlock { Id = Guid.Parse("0ffe861a-0fbe-48ab-9132-b8fca4ead8ef"), Type = TextBlockType.Text, Text = "You attempt to knock an opponent off their mount. Make a melee (action: Strike) against a mounted opponent. If your attack hits, attempt an Athletics check against the opponent's Fortitude DC. If you succeed, the foe is knocked off its mount into a space of its choice adjacent to its mount. If you critically succeed, it lands prone." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("82792db1-cab5-4dfc-a6d6-8c11b36f56d3"), Feats.Instances.CavalierDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa0592b4-7485-40a1-9cec-59dc8d0f30b0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
