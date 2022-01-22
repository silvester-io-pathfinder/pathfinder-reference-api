using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FollowUpStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("15ca168d-16c4-46b5-87a9-0dacc1da52d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Follow-Up Strike",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3999c8f6-229a-4359-8269-54f8ae03d276"), Type = TextBlockType.Text, Text = $"You have trained to use all parts of your body as a weapon, and when you miss with an attack, you can usually continue the attack with a different body part and still deal damage. Make another {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a melee unarmed attack, using the same multiple attack penalty as for the missed {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, if any." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c9e84707-de24-424a-93d7-7750dbdd1062"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("147ee3ce-3416-466f-91e4-21bdb7b5bcc6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
