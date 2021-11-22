using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LastwallSentryDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("8f11fc75-1439-49cc-9f2f-9b38c346fddc");

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
            yield return new TextBlock { Id = Guid.Parse("fadaca36-cc55-45ed-871b-ef100f909f2c"), Type = TextBlockType.Text, Text = "~ Access: You are from the Eye of Dread region." };
            yield return new TextBlock { Id = Guid.Parse("7583f3e0-f2f5-4495-8075-0d84d0a5f318"), Type = TextBlockType.Text, Text = "You've sworn yourself as a sentry for the Knights of Lastwall, the first line of defense against incursions by the Whispering Tyrant throughout Golarion. You become trained in Athletics and in Undead Lore; if you were already trained, you become an expert instead. Finally, you gain the (feat: Reactive Shield) feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("ce82cff4-5c06-4865-9a48-0189b46ae3db"), "Member of the Knights of Lastwall.");
            builder.HaveSpecificFeat(Guid.Parse("1222ba1f-f4ac-4ab2-8520-789d796e2302"), Feats.Instances.ShieldBlock.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a036604e-71bc-4239-970c-34b6c81460ce"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
