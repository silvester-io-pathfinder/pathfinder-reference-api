using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SilentSting : Template
    {
        public static readonly Guid ID = Guid.Parse("2727482a-c7e6-4816-93f4-75eda3c89683");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Silent Sting",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You make a Strike with a weapon of light bulk.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("13c05dd4-4c9b-4e53-9bed-7490df014812"), Type = TextBlockType.Text, Text = "You quickly hide your weapon to make it difficult to pin the attack on you. You attempt to (action: Conceal an Object) to hide the triggering weapon. Your Stealth check is compared to the Perception DC of all creatures within 30 feet that can see you. You automatically succeed against creatures farther than 30 feet. The target of your (action: Strike) gains a +4 circumstance bonus to their Perception DC for this check. If your Stealth check is a success, you hide your weapon so well that the creature can&#39;t clearly determine where the attack originated." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2c19f714-e66f-4d4e-98fd-d9e5fc5092c5"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f8cc493-a2b3-4360-89f9-70efc2c73885"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
