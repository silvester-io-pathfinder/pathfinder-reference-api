using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeadlyAim : Template
    {
        public static readonly Guid ID = Guid.Parse("5f1523c5-cb97-419b-951c-83a32c5a68a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deadly Aim",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ec685595-6922-494c-aea3-fe35f31a4314"), Type = TextBlockType.Text, Text = $"You aim for your prey's weak spots, making your shot more challenging but dealing more damage if you hit. Make a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against your hunted prey at a -2 penalty. You gain a +4 circumstance bonus to damage on that {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. This bonus increases to +6 at 11th level and +8 at 15th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("8fa35d9b-4acd-45eb-91cc-e934e35da00d"), ClassFeatures.Rangers.WeaponSpecialization.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a499ac73-e80e-4787-b99c-596d0b96141c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
