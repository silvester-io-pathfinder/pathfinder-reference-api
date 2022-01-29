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
    public class ShieldedStride : Template
    {
        public static readonly Guid ID = Guid.Parse("cf132ddd-dd07-49c5-b9b9-e157bd6de366");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shielded Stride",
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
            yield return new TextBlock { Id = Guid.Parse("96680656-e5e5-42ba-ae5e-d6dfbf6b22da"), Type = TextBlockType.Text, Text = $"When your shield is up, your enemies' blows can't touch you. When you have your shield raised, you can {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} to move half your Speed without triggering reactions that are triggered by your movement (such as {ToMarkdownLink<Models.Entities.Feat>("Attacks of Opportunity", Feats.Instances.AttackOfOpportunity.ID)}). You can use Shielded Stride while {ToMarkdownLink<Models.Entities.Action>("Flying", Actions.Instances.Fly.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Swimming", SkillActions.Instances.Swim.ID)} instead of {ToMarkdownLink<Models.Entities.Action>("Striding", Actions.Instances.Stride.ID)} if you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("abb01dad-e5cd-4f5b-847c-fde4660c8e87"), Feats.Instances.VikingDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5306c66d-0f91-4412-90ee-4727f609fa5c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
