using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SacredKi : Template
    {
        public static readonly Guid ID = Guid.Parse("7d6ddb1c-7296-4831-9c3f-b89e83d2f5b6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sacred Ki",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ff9c755-bad9-4698-b356-19cd85aa94fc"), Type = TextBlockType.Text, Text = $"The power of your faith suffuses your ki. When you select this feat, choose chaos, evil, good, or law. Your choice must match one of your deity's alignment components." };
            yield return new TextBlock { Id = Guid.Parse("f4def405-c473-4295-9e27-74ea308791b8"), Type = TextBlockType.Text, Text = $"When you cast the {ToMarkdownLink<Models.Entities.Spell>("ki strike", Spells.Instances.KiStrike.ID)} focus spell and damage a creature whose alignment is opposite your chosen alignment, you can choose for the {ToMarkdownLink<Models.Entities.Spell>("ki strike", Spells.Instances.KiStrike.ID)} damage to be of the chosen type. Additionally, you can substitute the damage from {ToMarkdownLink<Models.Entities.Spell>("ki blast", Spells.Instances.KiBlast.ID)} (or other ki spells that deal force damage, at the GM's discretion) with damage of your chosen alignment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a2442a6f-0899-4644-819b-37d4457cf6bd"), Feats.Instances.KiStrike.ID);
            builder.FollowAnyReligion(Guid.Parse("28683151-89f7-4407-9f6c-03676846dc5c"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bf6bfe0-28d2-41ab-99bc-45cad182ce04"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
