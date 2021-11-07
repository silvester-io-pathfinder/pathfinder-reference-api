using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LongNosedForm : Template
    {
        public static readonly Guid ID = Guid.Parse("d31f89af-c715-4980-8ce8-8f129f071399");

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
            yield return new TextBlock { Id = Guid.Parse("4aeed00d-2215-47f2-ad96-1f91c0473523"), Type = TextBlockType.Text, Text = "You can transform into a specific, curious-looking human form. This human form is the same age and body type as your tengu form and has roughly analogous physical traits, such as height, though your nose remains as long as your beak and your complexion has red undertones, no matter the skin color of your human form. Using Long-Nosed Form counts as creating a disguise for the (action: Impersonate) use of Deception. Due to your imperfect transformation, your transformation doesn&#39;t automatically defeat Perception DCs to determine whether you are human, though you may be able to explain away or hide your tengu traits. You lose your beak unarmed attack in your human form, as well as any other unarmed attacks you gained from a tengu heritage or ancestry feat. You can remain in your human form indefinitely, and you can shift back to your tengu form by using this action again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf460341-0ad8-4e96-867a-717d7bd68edc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
