using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DreamMay : Template
    {
        public static readonly Guid ID = Guid.Parse("d10dd567-6938-444d-9b73-04bf6ac9c243");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dream May",
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
            yield return new TextBlock { Id = Guid.Parse("bf76e2ca-207d-4e78-ad16-d9d453b7e362"), Type = TextBlockType.Text, Text = $"You are the child of a night hag, making one of your eyes violet or even black. Your mother's powers over sleep and dreams have given you a degree of resistance to those effects, granting you a +2 circumstance bonus to all saving throws against {ToMarkdownLink<Models.Entities.Trait>("sleep", Traits.Instances.Sleep.ID)} effects and effects that cause or alter dreams." };
            yield return new TextBlock { Id = Guid.Parse("8f6afd37-d7df-4191-97cd-c583306e4eeb"), Type = TextBlockType.Text, Text = $"In addition, sleep is more restorative for you. You regain HP equal to your Constitution modifier times double your level instead of just times your level, and you reduce any drained and doomed conditions you have by 2 instead of by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ce65fba-ca7d-4f16-934d-62c5457b623d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
