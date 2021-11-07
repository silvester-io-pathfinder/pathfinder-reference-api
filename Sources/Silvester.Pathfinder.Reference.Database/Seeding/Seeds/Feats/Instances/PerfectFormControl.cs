using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerfectFormControl : Template
    {
        public static readonly Guid ID = Guid.Parse("61d70c6a-2a09-4e10-940f-27ff7a7c27f1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perfect Form Control",
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
            yield return new TextBlock { Id = Guid.Parse("f5fcc2dd-b242-4004-9c55-95eaa6927ca3"), Type = TextBlockType.Text, Text = "Thanks to magic and muscle memory, you can stay in your alternate forms indefinitely; you may have even forgotten your original form. When you use (Feat: Form Control), instead of lasting 1 hour, (Spell: wild shape) is permanent until you (Activity: Dismiss) it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e1e4043f-467f-4544-8a83-26a4346f5f18"), Feats.Instances.FormControl.ID);
            builder.HaveSpecificStat(Guid.Parse("2f89493f-88f9-4fd4-a272-9afe0f72b9af"), requiredStatValue: 18, Stats.Instances.Strength.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4fa4da84-2fce-450d-b955-5f659596346d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
