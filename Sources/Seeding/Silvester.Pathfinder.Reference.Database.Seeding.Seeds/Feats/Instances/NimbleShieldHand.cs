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
    public class NimbleShieldHand : Template
    {
        public static readonly Guid ID = Guid.Parse("2ccb96e5-0827-45e2-ae23-02426a019276");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nimble Shield Hand",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c8427f2-0a01-4ce8-b8fc-95a93a908cb6"), Type = TextBlockType.Text, Text = $"You are so used to wielding a shield that you can do so even while using the hand that's holding it for other purposes. The hand you use to wield a shield counts as a free hand for the purposes of the {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action. You can also hold another object in this hand (but you still can't use it to wield a weapon). This benefit doesn't apply to {ToMarkdownLink<Models.Items.Instances.Shield>("tower shields", Items.Shields.Instances.TowerShield.ID)}, which are still too cumbersome." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ecaf57db-18aa-4e2c-a651-1a20ed92a064"), Feats.Instances.BastionDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1af88da4-0491-4779-b84c-b75bd9f507eb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
