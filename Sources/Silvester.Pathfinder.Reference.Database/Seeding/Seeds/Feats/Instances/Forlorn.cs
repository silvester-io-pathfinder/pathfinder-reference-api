using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Forlorn : Template
    {
        public static readonly Guid ID = Guid.Parse("13855f2b-2fa9-47bb-8a61-7bf4adbe967b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forlorn",
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
            yield return new TextBlock { Id = Guid.Parse("4cc58aaa-8365-492a-961b-11553542bfe1"), Type = TextBlockType.Text, Text = "Watching your friends age and die fills you with moroseness that protects you against harmful emotions. You gain a +1 circumstance bonus to saving throws against (trait: emotion) effects. If you roll a success on a saving throw against an emotion effect, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac96b250-4eb7-4b03-bf16-9c18f11bcace"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
