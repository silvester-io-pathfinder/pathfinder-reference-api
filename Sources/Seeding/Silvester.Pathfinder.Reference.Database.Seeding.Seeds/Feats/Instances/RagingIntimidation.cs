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
    public class RagingIntimidation : Template
    {
        public static readonly Guid ID = Guid.Parse("5268de49-0937-421e-be84-93810ded00fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Raging Intimidation",
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
            yield return new TextBlock { Id = Guid.Parse("3c8051fa-c4d2-4569-a20d-bdcd0d6f464d"), Type = TextBlockType.Text, Text = $"Your fury fills your foes with fear. While you are raging, your {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Scare to Death", Feats.Instances.ScareToDeath.ID)} actions gain the {ToMarkdownLink<Models.Entities.Trait>("rage", Traits.Instances.Rage.ID)} trait, allowing you to use them while raging. As soon as you meet the prerequisites for the skill feats {ToMarkdownLink<Models.Entities.Feat>("Intimidating Glare", Feats.Instances.IntimidatingGlare.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Scare to Death", Feats.Instances.ScareToDeath.ID)}, you gain these feats." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9dbc9290-fc39-458f-a458-30d425a5ef41"), Traits.Instances.Barbarian.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62aeeae6-7259-435f-ab43-b5ef9117d16f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
