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
    public class EnforceOath : Template
    {
        public static readonly Guid ID = Guid.Parse("4312482d-1706-4704-b6d9-8d22cf26bfd4");

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
            yield return new TextBlock { Id = Guid.Parse("456f1ac8-477a-4801-89fb-314b780a6244"), Type = TextBlockType.Text, Text = $"You call on your oath to embolden you in combat. When you Enforce your Oath, select one creature you can see that you've sworn to defeat as part of your oath. You gain a +1 status bonus to AC and saves against attacks and effects by the chosen creature. You also gain a +1 status bonus to attack rolls against the chosen creature. However, your dedication to Enforcing your Oath draws your focus away from all other foes. While you are Enforcing your Oath, you take a –1 status penalty to AC, attack rolls, and saves against all other creatures until you stop Enforcing your Oath." };
            yield return new TextBlock { Id = Guid.Parse("6b5e4ffb-e74b-42c9-b8a6-daed54a4d8da"), Type = TextBlockType.Text, Text = $"You stop Enforcing your Oath once the chosen creature is reduced to 0 Hit Points or offers a legitimate surrender to you or your allies. You immediately stop Enforcing your Oath if you are unconscious or if the chosen creature goes unnoticed by you for more than 1 minute. You can also stop Enforcing your Oath at any time during your turn as a free action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("e78e4a49-7ed9-48b3-b45f-1a5cd51c39cc"), "You've sworn to an oath against a specific type of creature.");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7497a910-5bba-4b6d-be98-017a071691bf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
