using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardingLight : Template
    {
        public static readonly Guid ID = Guid.Parse("4a61fef0-dea6-4b8f-a6fb-1992a448daa7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warding Light",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c17812dd-8c69-48b3-bf91-d803e056ff7c"), Type = TextBlockType.Text, Text = "You gain a tattoo that serves as a special ward to defend you against Walkena’s forces. The tattoo allows you to cast the (spell: light) cantrip as a divine innate spell at will. The cantrip is heightened to a spell level equal to half your level rounded up. If you die, the tattoo immediately casts (spell: gentle repose) on your corpse, heightened to the same spell level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fb648e3e-1d12-41d4-a4d8-a683946dbd5a"), Feats.Instances.BrightLionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c7e3a3b-e630-4dd1-bf35-136ce5fad1d8"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
