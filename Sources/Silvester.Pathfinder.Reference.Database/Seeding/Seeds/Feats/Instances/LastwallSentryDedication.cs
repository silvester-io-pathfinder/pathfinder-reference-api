using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LastwallSentryDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("69b3f6a5-6528-4ef8-8ce6-4503bb18d962");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lastwall Sentry Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the Lastwall sentry archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("647501e7-4d48-4e6a-9f99-219ecac8915a"), Type = TextBlockType.Text, Text = "~ Access: You are from the Eye of Dread region." };
            yield return new TextBlock { Id = Guid.Parse("ed89f6cf-cc7d-4e59-a10f-72ffcdc13f01"), Type = TextBlockType.Text, Text = "You’ve sworn yourself as a sentry for the Knights of Lastwall, the first line of defense against incursions by the Whispering Tyrant throughout Golarion. You become trained in Athletics and in Undead Lore; if you were already trained, you become an expert instead. Finally, you gain the (feat: Reactive Shield) feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("03a15b90-58f5-4e17-a882-51c9ac359c4c"), "Member of the Knights of Lastwall.");
            builder.HaveSpecificFeat(Guid.Parse("3102b73f-ddfa-43f7-a705-df77ffb0fa82"), Feats.Instances.ShieldBlock.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d1e31c7-3248-402d-836b-f0fe610df68b"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
