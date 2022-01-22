using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormControl : Template
    {
        public static readonly Guid ID = Guid.Parse("cd5f9cfd-656e-4cc5-9541-49336acadaf3");

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
            yield return new TextBlock { Id = Guid.Parse("cec57547-7cca-4a9b-8bd4-184519635d85"), Type = TextBlockType.Text, Text = $"With additional care and effort, you can take on an alternate form for a longer period of time. If your next action is to cast {ToMarkdownLink<Models.Entities.Spell>("wild shape", Spells.Instances.WildShape.ID)}, wild shape's spell level is 2 lower than normal (minimum 1st level), but you can remain transformed for up to 1 hour or the listed duration (whichever is longer). You can still {ToMarkdownLink<Models.Entities.Action>("Dismiss", Actions.Instances.Dismiss.ID)} the form at any time, as permitted by the spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("72004f4b-14e1-4247-b3e2-e2b9c3691b4d"), requiredStatValue: 14, Stats.Instances.Strength.ID);
            builder.HaveSpecificFeat(Guid.Parse("f648c69a-20ea-4b11-8dcd-3416006c0701"), Feats.Instances.WildShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("847015d1-d37a-49c0-ad80-f7bd8d0e5200"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
