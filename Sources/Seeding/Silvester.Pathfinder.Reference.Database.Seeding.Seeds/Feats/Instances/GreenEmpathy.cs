using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreenEmpathy : Template
    {
        public static readonly Guid ID = Guid.Parse("d412e04a-3959-47b5-b1fc-4a31a237fae0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Green Empathy",
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
            yield return new TextBlock { Id = Guid.Parse("ee6be032-1d77-484d-b3ef-acd0601c52a6"), Type = TextBlockType.Text, Text = $"You can communicate with plants on a basic level and use Diplomacy to {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)} on them and to make very simple {ToMarkdownLink<Models.Entities.SkillAction>("Requests", SkillActions.Instances.Request.ID)} of them. Non-creature plants typically can't fulfill most requests you might ask of them unless you have access to other magic such as {ToMarkdownLink<Models.Entities.Spell>("speak with plants", Spells.Instances.SpeakWithPlants.ID)}. Because of your affiliation with the leaf order, plants have a sense that you support them, so you gain a +2 circumstance bonus on your check to make a {ToMarkdownLink<Models.Entities.SkillAction>("Request", SkillActions.Instances.Request.ID)} of a plant using Green Empathy." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("062bb876-c2bd-4199-b771-11f0fd871f7b"), DruidicOrders.Instances.Leaf.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99cda28b-88a1-4bca-8c37-2338c83f7842"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
