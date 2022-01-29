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
    public class FellRider : Template
    {
        public static readonly Guid ID = Guid.Parse("fff7cc86-f992-4be4-bfe3-b7600ff0d82a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fell Rider",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("679ca285-efcc-48c5-9fbc-c015b816effb"), Type = TextBlockType.Text, Text = $"You have trained with your animal companion to become a terrifying, unified juggernaut on the battlefield. Your animal companion becomes trained in Intimidation. If your animal companion uses Support while serving as your mount, it grants you the effects of the {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} reaction on your first Intimidation check to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} on the same turn, even though it can't take reactions." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAnimalCompanionAmount(Guid.Parse("970f0c3a-74f5-4e0b-b962-37a8c395796e"), Comparator.GreaterThanOrEqualTo, amount: 1);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f029ede-c775-447f-9e6c-bacc5b47d4a1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
