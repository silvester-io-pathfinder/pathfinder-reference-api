using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrueShapeshifter : Template
    {
        public static readonly Guid ID = Guid.Parse("82b0e58b-0a74-4b55-86fd-c05016882a85");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "True Shapeshifter",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f13f6857-6c81-4b26-8553-5329be2cd833"), Type = TextBlockType.Text, Text = "You transcend the limitations of form. While under the effects of (Spell: wild shape), you can change into any other form on your (Spell: wild shape) list; if the durations of the forms would vary, use the shorter of the two durations." };
            yield return new TextBlock { Id = Guid.Parse("eb981d7b-9aac-465d-a0a2-c1030d302deb"), Type = TextBlockType.Text, Text = "Once per day, you can transform into a kaiju, with the effects of (Spell: nature incarnate); if you have (Feat: Plant Shape), you can instead transform into a green man." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5ed6458b-9d18-4489-be53-00b8e1a5a651"), Feats.Instances.WildShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d4bc4c3-aecb-4cc2-b28b-f0d451aeaafd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
