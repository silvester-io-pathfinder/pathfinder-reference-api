using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("e93b364a-a1e6-4a42-afd7-e586929cf6d6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warding Rune",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de5ec9ae-d1d5-4e81-9ca5-ab81622a014c"), Type = TextBlockType.Text, Text = "Your runes provide a warding effect that protects you against a specific school of magic. Choose a school of magic other than (trait: divination). You gain a rune on your body corresponding to that school, and you gain a +2 circumstance bonus to all saving throws against effects of that school." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("deca43da-3a04-40d4-96da-1b042287fc17"), Feats.Instances.RunescarredDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7992cfd-af2d-4800-ae34-3cacf1e49707"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
