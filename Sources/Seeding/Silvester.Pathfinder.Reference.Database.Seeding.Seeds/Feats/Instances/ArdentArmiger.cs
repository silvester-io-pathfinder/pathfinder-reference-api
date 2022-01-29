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
    public class ArdentArmiger : Template
    {
        public static readonly Guid ID = Guid.Parse("cc0dd909-522a-498b-8bc2-c93997e19f93");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ardent Armiger",
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
            yield return new TextBlock { Id = Guid.Parse("f7a7d08b-af77-498d-a5f1-8a34a59e9548"), Type = TextBlockType.Text, Text = $"You have been trained to resist the manipulations of fiends, and your Hellknight discipline makes you difficult to influence. You gain a +1 circumstance bonus to saves against {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)} effects that specifically improve your attitude and to your Will DC against someone {ToMarkdownLink<Models.Entities.SkillAction>("Coercing", SkillActions.Instances.Coerce.ID)} you, {ToMarkdownLink<Models.Entities.SkillAction>("Demoralizing", SkillActions.Instances.Demoralize.ID)} you, {ToMarkdownLink<Models.Entities.SkillAction>("Making an Impression", SkillActions.Instances.MakeAnImpression.ID)} on you, or making a {ToMarkdownLink<Models.Entities.SkillAction>("Request", SkillActions.Instances.Request.ID)} of you." };
            yield return new TextBlock { Id = Guid.Parse("a4bfc227-2dc5-4f97-8e4e-98e97781ddf3"), Type = TextBlockType.Text, Text = $"If a {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)} effect would compel you to act in a way that violates your Hellknight order's tenets (as determined by the GM), you can attempt to break free from the effect as a reaction triggered by receiving the violating order, and you gain a new Will save against the effect. You can attempt this new save only once for a given effect, even if you are compelled to violate your order's tenets multiple times." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eee7fe90-adce-4085-bdb1-f5933a499f79"), Feats.Instances.HellknightArmigerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("273e7ceb-bce0-4fc1-a9af-e56500dc88fa"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd39ce00-177b-4567-9c29-d61a4fc00d2c"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
