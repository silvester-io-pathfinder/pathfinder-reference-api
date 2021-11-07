using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormControl : Template
    {
        public static readonly Guid ID = Guid.Parse("58ce2154-b0aa-4393-8529-7c7b9c9173c7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form Control",
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
            yield return new TextBlock { Id = Guid.Parse("7f6efe13-303b-4788-9931-1eda354c0577"), Type = TextBlockType.Text, Text = "With additional care and effort, you can take on an alternate form for a longer period of time. If your next action is to cast (Spell: wild shape), wild shape’s spell level is 2 lower than normal (minimum 1st level), but you can remain transformed for up to 1 hour or the listed duration (whichever is longer). You can still (Activity: Dismiss) the form at any time, as permitted by the spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("731b0360-1ee0-4f97-9a2b-84b3774fce92"), requiredStatValue: 14, Stats.Instances.Strength.ID);
            builder.HaveSpecificFeat(Guid.Parse("8bfb2d05-d56d-449a-ba27-9b9e6f0cc93f"), Feats.Instances.WildShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e380d2a-2ae2-4f48-a59d-fe04d98a4c10"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
