using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Evangelize : Template
    {
        public static readonly Guid ID = Guid.Parse("b5a9e738-e88e-49d0-90b5-57ecdb4c8785");

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
            yield return new TextBlock { Id = Guid.Parse("e80f2f8a-d4b4-4058-8ea3-5533813cf32b"), Type = TextBlockType.Text, Text = "You point out a detail that incontrovertibly supports your faith, causing a listener’s mind to whirl. Attempt a Diplomacy check and compare the result to the Will DC of a single target that can hear you and understands your language; that target is then temporarily immune to Evangelize with respect to your deity or philosophy for 1 day. A creature that already agrees with you is unaffected, and at the GM’s discretion, a target that genuinely changes its perspective to support your faith as a result of the argument is also otherwise unaffected." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d0364a23-f91e-43f9-928c-9d515b7cc1e1"), Proficiencies.Instances.Master.ID, Skills.Instances.Diplomacy.ID);
            builder.AddOr(Guid.Parse("93a0391a-6482-4aab-b85e-f97ef76121e0"), or => 
            {
                or.FollowAnyReligion(Guid.Parse("ed75c772-df07-46e3-a782-51e9736d4b46"));
                or.FollowAnyPhilosophy(Guid.Parse("3c7d89f2-9e02-497e-a5cc-94b97470b5ca"));
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("a76d91c8-b86d-46a1-9a5f-e4de672f043a"),
                CriticalSuccess = "The target is stupefied 2 for 1 round.",
                Success = "The target is stupefied 1 for 1 round.",
                Failure = "The target is unaffected.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c507464-89d1-4983-91bb-595acf14b088"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
