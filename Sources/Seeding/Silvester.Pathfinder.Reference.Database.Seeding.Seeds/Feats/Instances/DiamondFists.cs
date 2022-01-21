using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiamondFists : Template
    {
        public static readonly Guid ID = Guid.Parse("3a65c3b8-be3d-4661-b257-caed454c765a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diamond Fists",
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
            yield return new TextBlock { Id = Guid.Parse("6f4e12e8-85e1-45d6-b0db-01b969447996"), Type = TextBlockType.Text, Text = $"Your body hardens as you combine your attacks, making your finishing blows more damaging. Your unarmed attacks gain the {ToMarkdownLink<Models.Entities.Trait>("forceful", Traits.Instances.Forceful.ID)} trait. Any that already had this trait instead increase their weapon damage dice by one step." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17f5adf9-2af4-4d61-8bc9-100fffcbbb02"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
