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
    public class Evangelize : Template
    {
        public static readonly Guid ID = Guid.Parse("4fde96aa-1ad8-4c10-95f0-f103d9ba3e53");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Evangelize",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a99e3bc-e248-415c-92b3-8a58b1b60d44"), Type = TextBlockType.Text, Text = $"You point out a detail that incontrovertibly supports your faith, causing a listener's mind to whirl. Attempt a Diplomacy check and compare the result to the Will DC of a single target that can hear you and understands your language; that target is then temporarily immune to Evangelize with respect to your deity or philosophy for 1 day. A creature that already agrees with you is unaffected, and at the GM's discretion, a target that genuinely changes its perspective to support your faith as a result of the argument is also otherwise unaffected." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("99b89048-bd03-4007-a684-4bd9e6be78d2"), Proficiencies.Instances.Master.ID, Skills.Instances.Diplomacy.ID);
            builder.AddOr(Guid.Parse("9642727d-fe83-4632-92a9-334a1ddac9fc"), or => 
            {
                or.FollowAnyReligion(Guid.Parse("d6f6b52c-3ddd-4df0-8eea-9e62667c1a9d"));
                or.FollowAnyPhilosophy(Guid.Parse("f3fb87f5-ece9-443a-9dea-32589ba5b191"));
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("85159498-febe-4d86-808f-c51e7e93c400"),
                CriticalSuccess = "The target is stupefied 2 for 1 round.",
                Success = "The target is stupefied 1 for 1 round.",
                Failure = "The target is unaffected.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ecd3a851-d588-4170-b1a9-77abcf358672"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
