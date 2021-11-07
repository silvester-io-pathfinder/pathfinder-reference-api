using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EldritchDebilitations : Template
    {
        public static readonly Guid ID = Guid.Parse("fe38e8cd-f772-4630-98f5-d3537483d7f7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eldritch Debilitations",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b2de8ed4-50d6-4e9c-8353-b41e1f77e9e7"), Type = TextBlockType.Text, Text = "You know how to apply debilitations that are particularly troublesome for spellcasters. Add the following debilitations to the list you can choose from when you use (feat: Debilitating Strike)." };
            yield return new TextBlock { Id = Guid.Parse("ab2be4e7-83fa-4f07-a3a6-82edfe9460f0"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target is stupefied 1." };
            yield return new TextBlock { Id = Guid.Parse("356d8718-eace-4237-9818-c379b87c027d"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target can’t (action: Step)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("be304ce5-8dc2-471a-a727-5db4edcdf4af"), Rackets.Instances.EldritchTrickster.ID);
            builder.HaveSpecificFeat(Guid.Parse("6bf992be-5c88-4472-9c38-673b46c1f450"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16e810dc-7e9c-45e2-a29d-b18e364f7aed"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
