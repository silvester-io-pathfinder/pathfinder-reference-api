using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprobableElixirs : Template
    {
        public static readonly Guid ID = Guid.Parse("5a217a72-2a23-4a26-917c-4f12a7868d7a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improbable Elixirs",
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
            yield return new TextBlock { Id = Guid.Parse("8bbde398-719b-4813-86e0-04f764072003"), Type = TextBlockType.Text, Text = "Your mastery of alchemical secrets enables you to replicate effects most believe can be achieved only via magic. Select a number of potions equal to your Intelligence modifier (minimum 1) of 9th level or lower. You gain formulas to create these potions as alchemical items with the (trait: elixir) trait. When making these alchemical elixirs, you can substitute alchemical reagents for an equal value of magical components, and you can use (item: alchemist&#39;s tools) (for (feat:lvl--1: Quick Alchemy)) or an (item: alchemist&#39;s lab) (for the (action: Craft) activity) instead of any other required tool kits. Other than that, the formula does not change. Once you’ve chosen the potion formulas, they can’t be changed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("579b0f9a-9123-4a26-b20c-4dd48f351e12"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
