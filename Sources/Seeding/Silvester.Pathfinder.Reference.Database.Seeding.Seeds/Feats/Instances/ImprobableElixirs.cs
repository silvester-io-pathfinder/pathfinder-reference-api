using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprobableElixirs : Template
    {
        public static readonly Guid ID = Guid.Parse("158400c1-5c6f-4b93-8e22-706d551365be");

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
            yield return new TextBlock { Id = Guid.Parse("f843784b-c383-40aa-b42f-3a09537ff6da"), Type = TextBlockType.Text, Text = $"Your mastery of alchemical secrets enables you to replicate effects most believe can be achieved only via magic. Select a number of potions equal to your Intelligence modifier (minimum 1) of 9th level or lower. You gain formulas to create these potions as alchemical items with the {ToMarkdownLink<Models.Entities.Trait>("elixir", Traits.Instances.Elixir.ID)} trait. When making these alchemical elixirs, you can substitute alchemical reagents for an equal value of magical components, and you can use {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("alchemist's tools", Items.AdventuringGears.Instances.AlchemistsTools.ID)} (for {ToMarkdownLink<Models.Entities.Feat>("Quick Alchemy", Feats.Instances.QuickAlchemy.ID)}) or an {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("alchemist's lab", Items.AdventuringGears.Instances.AlchemistsLab.ID)} (for the {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} activity) instead of any other required tool kits. Other than that, the formula does not change. Once you've chosen the potion formulas, they can't be changed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0fb7912e-ef90-424a-91ee-b9fa1d2f22fd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
