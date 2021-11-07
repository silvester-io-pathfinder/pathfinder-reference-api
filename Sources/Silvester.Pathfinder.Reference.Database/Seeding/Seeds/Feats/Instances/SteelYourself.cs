using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteelYourself : Template
    {
        public static readonly Guid ID = Guid.Parse("778595a6-fdcb-4858-bbde-8039edb748aa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steel Yourself!",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("74a9fe59-369a-49c4-ac8a-b12f04bec676"), Type = TextBlockType.Text, Text = "You encourage an ally to toughen up, giving them a fighting chance. Choose one ally within your marshal’s aura. The ally gains temporary Hit Points equal to your Charisma modifier and a +2 circumstance bonus to Fortitude saves. Both benefits last until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("af603f0e-6df3-45de-89a2-e78d83182a9c"), Feats.Instances.MarshalDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5bfb42f2-1977-43f7-9046-b54a1d96c2b5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
