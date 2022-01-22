using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InnateMagicIntuition : Template
    {
        public static readonly Guid ID = Guid.Parse("d38d9d3f-0364-45fd-bbfb-700453bac053");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Innate Magic Intuition",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f4ba3d01-815d-4df3-a961-f11740590dab"), Type = TextBlockType.Text, Text = $"You've spent countless hours learning to recognize and predict a creature's innate magical abilities. The first time you successfully {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} to identify a creature, in addition to any information you learn from your successful check, you learn the names of three of the highest-level innate spells it can cast, and you gain a +2 circumstance bonus on your next save against an innate spell cast by that creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2d8f7ede-58bb-4abf-80f0-31f9ab0411ef"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c63da3f-e485-48c5-a834-3a0f0c0adc0b"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
