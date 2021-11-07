using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnforceOath : Template
    {
        public static readonly Guid ID = Guid.Parse("a3e25b0c-de65-4b6c-a2ff-b2ee6c9c5b70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enforce Oath",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41bf5598-4046-4823-83f0-a8d8e241e20a"), Type = TextBlockType.Text, Text = "You call on your oath to embolden you in combat. When you Enforce your Oath, select one creature you can see that you’ve sworn to defeat as part of your oath. You gain a +1 status bonus to AC and saves against attacks and effects by the chosen creature. You also gain a +1 status bonus to attack rolls against the chosen creature. However, your dedication to Enforcing your Oath draws your focus away from all other foes. While you are Enforcing your Oath, you take a –1 status penalty to AC, attack rolls, and saves against all other creatures until you stop Enforcing your Oath." };
            yield return new TextBlock { Id = Guid.Parse("414ee1c6-916c-4fe4-aa59-fbfc7e487507"), Type = TextBlockType.Text, Text = "You stop Enforcing your Oath once the chosen creature is reduced to 0 Hit Points or offers a legitimate surrender to you or your allies. You immediately stop Enforcing your Oath if you are unconscious or if the chosen creature goes unnoticed by you for more than 1 minute. You can also stop Enforcing your Oath at any time during your turn as a free action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("53ca99e3-9c5b-41f7-8c12-ceae41fbaf87"), "You've sworn to an oath against a specific type of creature.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("582c5542-afa7-4801-a4e7-c961d63df293"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
