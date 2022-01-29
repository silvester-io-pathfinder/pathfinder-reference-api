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
    public class LongNosedForm : Template
    {
        public static readonly Guid ID = Guid.Parse("6dd378c1-5a43-4ed8-8523-fd6a417c35a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Long-Nosed Form",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2c31cccf-f678-4158-927f-771e2fdd6ae5"), Type = TextBlockType.Text, Text = $"You can transform into a specific, curious-looking human form. This human form is the same age and body type as your tengu form and has roughly analogous physical traits, such as height, though your nose remains as long as your beak and your complexion has red undertones, no matter the skin color of your human form. Using Long-Nosed Form counts as creating a disguise for the {ToMarkdownLink<Models.Entities.SkillAction>("Impersonate", SkillActions.Instances.Impersonate.ID)} use of Deception. Due to your imperfect transformation, your transformation doesn't automatically defeat Perception DCs to determine whether you are human, though you may be able to explain away or hide your tengu traits. You lose your beak unarmed attack in your human form, as well as any other unarmed attacks you gained from a tengu heritage or ancestry feat. You can remain in your human form indefinitely, and you can shift back to your tengu form by using this action again." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8bfdf6e6-87c9-42b7-85e0-3c845fef40e3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
