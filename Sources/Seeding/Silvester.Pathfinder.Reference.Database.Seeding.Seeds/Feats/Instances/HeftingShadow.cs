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
    public class HeftingShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("fd47b352-739a-42f3-b6ae-728694a3c77e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hefting Shadow",
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
            yield return new TextBlock { Id = Guid.Parse("0133b97b-5aed-46d9-a1ce-1f77dc17d20d"), Type = TextBlockType.Text, Text = $"Your shadow can contain objects. You can {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} with your shadow to store or retrieve objects, just like you would a mundane container (meaning you spend two {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions total to store and then retrieve the object, for example). Your shadow can contain 2 Bulk of objects, which don't count toward the Bulk you're carrying. The items remain solid but take on a shadowy patina while stored this way. Though the items are in your shadow and can be detected normally, you gain a +2 circumstance bonus to Stealth checks to {ToMarkdownLink<Models.Entities.SkillAction>("Conceal the Objects", SkillActions.Instances.ConcealAnObject.ID)} unless someone knows to check your shadow for items." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b90e895a-c71f-4533-9c5a-fc4ebf604475"), Feats.Instances.CleverShadow.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Fetchling.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Occult.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Shadow.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8ddeea1-994e-4f7a-81ee-63f9f054db36"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
