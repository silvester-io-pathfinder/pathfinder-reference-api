using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FocusAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("ea13c35d-9752-4e96-9a3d-e13cf501c02e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Focus Ally",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An adjacent ally fails, but doesn't critically fail, a saving throw against an effect with the incapacitation trait.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("10e040d8-74e6-4198-945a-2a53cc14e708"), Type = TextBlockType.Text, Text = "You&#39;re so focused on your allies that you can help them to recenter when something would take them out of the fight. Your ally rerolls the failed saving throw. That ally must take the second result." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("15a99571-d9c5-42b6-9f2d-52062e6bb89a"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d60c9d8-55a1-4d4f-aa50-9e5bf781e6a2"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
