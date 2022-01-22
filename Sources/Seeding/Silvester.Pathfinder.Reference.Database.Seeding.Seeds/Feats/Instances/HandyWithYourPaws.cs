using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HandyWithYourPaws : Template
    {
        public static readonly Guid ID = Guid.Parse("9793bba7-071e-40cb-8e7a-384215844a70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Handy With Your Paws",
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
            yield return new TextBlock { Id = Guid.Parse("8d0dad56-992c-44c7-95fa-5f82e5c94f8e"), Type = TextBlockType.Text, Text = $"You gain a +1 circumstance bonus to Crafting checks to {ToMarkdownLink<Models.Entities.SkillAction>("Repair", SkillActions.Instances.Repair.ID)} non-magical items, and you don't need a repair kit for such repairs as long as you have any amount of junk, spare parts, or debris at your disposal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("feae4fd8-c3df-45f1-8909-92fca73ff324"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
