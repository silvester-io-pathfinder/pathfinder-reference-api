using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FirstRevelation : Template
    {
        public static readonly Guid ID = Guid.Parse("8e45dd0e-a183-4dff-8d31-ad5c3acf2349");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "First Revelation",
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
            yield return new TextBlock { Id = Guid.Parse("9add1715-c36b-4cda-b5cc-69df93e5eefa"), Type = TextBlockType.Text, Text = "You gain your mystery’s initial revelation spell. Casting this spell progresses your curse (APG pg. 70). Use the minor curse from your mystery, but when you progress it again, instead of your mystery’s moderate curse effect, you become flat-footed in addition to the effects of the minor curse." };
            yield return new TextBlock { Id = Guid.Parse("67840ba6-14ae-4637-a070-89a30e59da7f"), Type = TextBlockType.Text, Text = "If you don’t have one, you gain a focus pool of 1 Focus Point. You can (action: Refocus) by reconciling the conflicting nature of your mystery, which also reduces your curse to minor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("53044e45-bb02-4456-9f48-d760f38217b4"), Feats.Instances.OracleDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("603dafc4-9f48-48a3-8458-ba87d3d887ce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
