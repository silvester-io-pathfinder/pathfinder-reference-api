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
    public class GodlessHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("5e0f0dc5-47e0-4a35-9382-5d8f47da23a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Godless Healing",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3fe879a1-8f61-41bf-b8d1-ba1dfa478455"), Type = TextBlockType.Text, Text = $"You recover an additional 5 Hit Points from a successful attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Treat your Wounds", SkillActions.Instances.TreatWounds.ID)} or use {ToMarkdownLink<Models.Entities.Feat>("Battle Medicine", Feats.Instances.BattleMedicine.ID)} on you. After you or an ally use {ToMarkdownLink<Models.Entities.Feat>("Battle Medicine", Feats.Instances.BattleMedicine.ID)} on you, you become temporarily immune to that {ToMarkdownLink<Models.Entities.Feat>("Battle Medicine", Feats.Instances.BattleMedicine.ID)} for only 1 hour, instead of 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("78c15e80-5dc1-4ed2-a6c4-9204d7a4d66c"), Feats.Instances.BattleMedicine.ID);
            builder.Manual(Guid.Parse("ec3fc588-58f6-4222-8f9e-cec435e55a32"), "Can't have a patron deity.");
            //TODO: Add prerequisites.
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("533bfe2a-3e0f-43d5-aa11-2c2e437d28c8"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
