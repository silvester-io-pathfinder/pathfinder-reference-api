using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("cd3b9af6-a450-4b0f-ac5e-c91562b27dac");

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
            yield return new TextBlock { Id = Guid.Parse("39c2b775-ee88-4794-9e09-e6512a8e5096"), Type = TextBlockType.Text, Text = $"Your runes provide a warding effect that protects you against a specific school of magic. Choose a school of magic other than {ToMarkdownLink<Models.Entities.Trait>("divination", Traits.Instances.Divination.ID)}. You gain a rune on your body corresponding to that school, and you gain a +2 circumstance bonus to all saving throws against effects of that school." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5fb4399a-f918-4101-9f90-dcca15dbf1fd"), Feats.Instances.RunescarredDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35b964db-af75-4341-b4aa-a4f7a0d49f48"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
