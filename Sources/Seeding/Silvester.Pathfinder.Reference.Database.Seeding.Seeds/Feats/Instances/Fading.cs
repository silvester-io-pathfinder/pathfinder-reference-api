using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Fading : Template
    {
        public static readonly Guid ID = Guid.Parse("6c5d6ed4-b1dd-4904-a7d6-917337bfa2d9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fading",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are targeted with a Strike by someone you can detect while your Crimson Shroud is active.",
                Frequency = "once per Crimson Shroud"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ccfcdf7f-7c0b-4ecc-aa3f-dbed315ab6ed"), Type = TextBlockType.Text, Text = $"You fade partially from reality. The attacker must attempt a DC 11 flat check; on a failure, the attack passes harmlessly through the image of your body that remains behind. An instant later you return to reality, and your {ToMarkdownLink<Models.Entities.Feat>("Crimson Shroud", Feats.Instances.CrimsonShroud.ID)} ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c5843170-ff12-4348-b800-51555e24e71c"), Feats.Instances.CrimsonShroud.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2752c6ca-bbf4-49bc-8b99-86252382ad59"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
