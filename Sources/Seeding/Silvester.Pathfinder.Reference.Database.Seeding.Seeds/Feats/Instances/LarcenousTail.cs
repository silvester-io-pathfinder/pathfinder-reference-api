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
    public class LarcenousTail : Template
    {
        public static readonly Guid ID = Guid.Parse("9be4aef5-d85f-448c-b1c6-a8175d4b4122");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Larcenous Tail",
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
            yield return new TextBlock { Id = Guid.Parse("79e3af44-d77b-4689-95bf-e901fd3a1043"), Type = TextBlockType.Text, Text = $"Your tail's chaotic and independent nature causes it to perform mischief even when you don't intend it, and it can somehow steal things it shouldn't be able to handle. You can use your tail to {ToMarkdownLink<Models.Entities.SkillAction>("Steal", SkillActions.Instances.Steal.ID)} an object, though your tail still can't hold onto it at the end of your action. If you have a hand free, you can transfer the stolen object to your hand. Otherwise, your tail surreptitiously drops it on the ground in your space, where you can grab it later. Observers other than your target who haven't witnessed you stealing something with your tail are usually distracted, meaning the GM will usually decrease their Perception DCs, as normal for {ToMarkdownLink<Models.Entities.SkillAction>("Stealing", SkillActions.Instances.Steal.ID)} something." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d2d43cc2-63ad-4f8b-b7cc-ad9c0190b34a"), Feats.Instances.SkillfulTail.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b2d6d4f-a45b-4c29-90fd-be89e269ab9a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
