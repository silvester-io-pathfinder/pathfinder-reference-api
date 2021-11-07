using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedClarity : Template
    {
        public static readonly Guid ID = Guid.Parse("4959a662-aae2-4c5d-9deb-997901558551");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Clarity",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ebc8824-62f6-47f4-beb9-e61c6969f1b9"), Type = TextBlockType.Text, Text = "You can project your premonitions of clarity to your allies. When you use (feat: Premonition of Clarity), allies within 15 feet of you who failed the same saving throw against the same mental effect can also spend their reactions to reroll the failed saving throw with a +2 circumstance bonus." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("be972c94-0ae9-4c85-8a5e-989f20ef4122"), Feats.Instances.PremonitionOfClarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93fc1153-48c8-48db-bb7b-f3edbc184690"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
