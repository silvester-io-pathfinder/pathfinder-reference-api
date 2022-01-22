using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LingeringComposition : Template
    {
        public static readonly Guid ID = Guid.Parse("b04fb0d9-8931-4b2f-9add-695e1732ff69");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lingering Composition",
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
            yield return new TextBlock { Id = Guid.Parse("4ed91e75-b480-499e-9c09-60b8993598ed"), Type = TextBlockType.Text, Text = $"By adding a flourish, you make your compositions last longer. You learn the {ToMarkdownLink<Models.Entities.Spell>("lingering composition", Spells.Instances.LingeringComposition.ID)} composition spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("04af1d8b-79bc-4edd-b099-e133dcbdf617"), Muses.Instances.Maestro.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e28d62a-d5e7-4671-acd4-0bdcf1da8a89"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
