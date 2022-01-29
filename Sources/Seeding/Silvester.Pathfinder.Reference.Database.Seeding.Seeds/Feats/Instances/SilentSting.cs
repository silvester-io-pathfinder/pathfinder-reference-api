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
    public class SilentSting : Template
    {
        public static readonly Guid ID = Guid.Parse("7e89bc04-e25d-461b-ab86-5aff4f9c2a3e");

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
            yield return new TextBlock { Id = Guid.Parse("936ed2fa-cdbc-4551-b796-b103889fd299"), Type = TextBlockType.Text, Text = $"You quickly hide your weapon to make it difficult to pin the attack on you. You attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Conceal an Object", SkillActions.Instances.ConcealAnObject.ID)} to hide the triggering weapon. Your Stealth check is compared to the Perception DC of all creatures within 30 feet that can see you. You automatically succeed against creatures farther than 30 feet. The target of your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} gains a +4 circumstance bonus to their Perception DC for this check. If your Stealth check is a success, you hide your weapon so well that the creature can't clearly determine where the attack originated." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("89494a94-d8cd-444d-bc49-5a7b0446edf7"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9eb1fe49-8d2e-4606-9744-a6cb24f63819"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
