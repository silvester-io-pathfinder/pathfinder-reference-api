using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RunningReload : Template
    {
        public static readonly Guid ID = Guid.Parse("551bf951-3ab4-455d-b90e-3fb3d4d21af0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Running Reload",
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
            yield return new TextBlock { Id = Guid.Parse("1e79ee60-fef0-4383-9f04-b8681eec5972"), Type = TextBlockType.Text, Text = $"You can reload your weapon on the move. You {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}, {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)}, then {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to reload." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70de0f5a-9f1d-4c9f-a018-4d5a85ce237c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
