using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Contortionist : Template
    {
        public static readonly Guid ID = Guid.Parse("00e6cc61-782b-4b42-b7ea-2286a75c56d3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Contortionist",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("440c3ef3-5a9f-4910-a2f8-914f91d13240"), Type = TextBlockType.Text, Text = "You can squeeze out of tight situations surprisingly quickly, gaining an advantage against foes that try to pin you down. You gain the (feat: Quick Squeeze) skill feat, and if you’re a master in Acrobatics, you can (action: Squeeze) at full Speed. Whenever you successfully (action: Escape) using Acrobatics, the creature you (action: Escaped | Escape) from is flat-footed against the next attack you make against it before the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9d62a8c6-2bd6-4d28-9375-d431d843289a"), Feats.Instances.AcrobatDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8504ddae-f9bc-4163-b0f8-140bda0e8328"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
