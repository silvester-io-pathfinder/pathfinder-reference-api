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
    public class MobileMagicalCombat : Template
    {
        public static readonly Guid ID = Guid.Parse("96a415c3-2dc7-4fdc-af5a-68d5fba68cea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mobile Magical Combat",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f9bb7fd-1725-4cbe-b7ec-f4bd37cd0533"), Type = TextBlockType.Text, Text = $"You dart around the battlefield, casting spells while you carefully make melee attacks with your weapon. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} once. If you end your movement within melee reach of at least one enemy, you can make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against that enemy. You can use Mobile Magical Combat while {ToMarkdownLink<Models.Entities.Action>("Burrowing", Actions.Instances.Burrow.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Climbing", SkillActions.Instances.Climb.ID)}, {ToMarkdownLink<Models.Entities.Action>("Flying", Actions.Instances.Fly.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Swimming", SkillActions.Instances.Swim.ID)} instead of {ToMarkdownLink<Models.Entities.Action>("Striding", Actions.Instances.Stride.ID)} if you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fe91661e-eb1f-4911-b306-d1e3b9a747d0"), Feats.Instances.SpellmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f48860a-c9cd-4fe1-8544-4e6d2bdde31f"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
